using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SerialPortDebug
{
    public partial class Form1 : Form
    {
        private int open_SerialPort_flag = 0;   //串口状态标志位
        private int AutoSend_flag = 0;          //自动发送标志位
        //private SerialPort Com_Using = new SerialPort();    //新建串口变量
        private uint Read_Cache_Data_flag = 0;             //读取缓存数据标志位
        private uint ComPort_closing = 0;                  //是否正在关闭串口
        //private byte* picture;
        private int Image_laod_Num = 0;        //自动播放图片序列
        private uint buttonAutoShowImage_flag=0;    //自动播放图片按钮标志位
        private string Image_save_path;            //保存图片路径字符串
        private UInt32 Image_save_Num = 1;          //保存图片时的名字变量
        //private int abc = 0;
        Bitmap camera_image_bit = new Bitmap(640, 480);
        private SerialPortDebug.FormWave fr_wave = new FormWave();
        private SerialPortDebug.MyFile my_file = new MyFile();
        private SerialPortDebug.FormSafety fm_safety = new FormSafety();

        public Form1()
        {
            InitializeComponent(); 
        }

        private void labelMs_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAutoSend_Click(object sender, EventArgs e)
        {
            AutoSend_flag++;
            if(AutoSend_flag==1)    //自动发送
            {
                if(textBoxTimeMs.Text=="")
                {
                    textBoxTimeMs.BackColor = Color.Blue;
                    toolStripStatusLabelMessage.Text = "亲，未输入发送间隔时间哦。";
                }
                else
                {
                    timerAutoSend.Interval = Convert.ToInt32(textBoxTimeMs.Text);
                    timerAutoSend.Enabled = true;
                    textBoxTimeMs.Enabled = false;
                    buttonAutoSend.Text = "停止发送";
                    toolStripStatusLabelMessage.Text = "正在自动发送";
                }
            }
            else     //取消自动发送
            {
                if (textBoxTimeMs.Text == "")
                {
                    AutoSend_flag = 0;
                    textBoxTimeMs.BackColor = Color.White;
                }
                else
                {
                    AutoSend_flag = 0;
                    timerAutoSend.Enabled = false;
                    textBoxTimeMs.Enabled = true;
                    buttonAutoSend.Text = "自动发送";
                }
            }
        }

        public void Init_Serialport()
        {
            //---------获取串口号--------//
            if (Serialport.portname_str.Length > 0)
            {
                comboBoxCom.SelectedText = Serialport.portname_str[0];
                foreach (string s in Serialport.portname_str)
                    comboBoxCom.Items.Add(s);
            }
            //--------选择波特率--------//
            comboBoxBaudRate.SelectedText = "115200";
            foreach (int baudrate in Serialport.BaudRates)
                comboBoxBaudRate.Items.Add(baudrate);
            //--------选择数据位--------//
            comboBoxByteSize.SelectedText = "8";
            foreach (int bytesize in Serialport.bytesizes)
                comboBoxByteSize.Items.Add(bytesize);
            //--------选择校验位-------//
            comboBoxParity.SelectedText = "0";
            foreach (int parity in Serialport.parities)
                comboBoxParity.Items.Add(parity);
            //---------选择停止位---------//
            comboBoxStopBits.SelectedText = "1";
            foreach (int stopbit in Serialport.stopbits)
                comboBoxStopBits.Items.Add(stopbit);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!fm_safety.Check_IsRegister())
            {
                fm_safety.Show();
                buttonOpenCom.Enabled = false;
                this.WindowState = FormWindowState.Minimized;
            }
            int image_width, image_height;
            Color back_form_color = new Color();
            back_form_color=my_file.Read_Log_FormMian_BackColor();
            this.BackColor = back_form_color;
            image_width = my_file.SetImage_Width();
            image_height = my_file.SetImage_Height();
            this.DoubleBuffered = true;
            Init_Serialport();
            
            buttonSend.Enabled = false;
            buttonAutoSend.Enabled = false;
            Myserialport.ReadBufferSize = 4096;
            //textBoxReceivingArea.Text=Com_Using.ReadBufferSize.ToString();
            timerFreshPort.Interval = 500;
            textBoxPictureWidth.Text = Convert.ToString(image_width);
            textBoxPictureHeight.Text = Convert.ToString(image_height);
            timerFreshPort.Enabled = true;
            pictureBoxShow.Image = camera_image_bit;
            pictureBoxShow1.Image = camera_image_bit;
            MyImage.camera_image_gra = Graphics.FromImage(pictureBoxShow.Image);
            MyImage.camera_image_gra1 = Graphics.FromImage(pictureBoxShow1.Image);
            //camera_image_gra.InterpolationMode =(InterpolationMode) CompositingQuality.HighQuality;
            MyImage.camera_image_gra.Clear(Color.Transparent);
            MyImage.camera_image_gra1.Clear(Color.Transparent);
            checkBoxSyetemTime.Checked = true;
            while (toolStripProgressBar1.Value < toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.PerformStep();
            }
        }

        private void buttonOpenCom_Click(object sender, EventArgs e)
        {
            ComPort_closing = 1;
            comboBoxCom.BackColor = Color.White;
            buttonOpenCom.BackColor = Color.Transparent;
            open_SerialPort_flag++;
            //Thread DealWith_Readdata_thread = new Thread(new ThreadStart(Deal_with_queuedata));
            if (open_SerialPort_flag==1)   //串口打开
            {
                if (comboBoxCom.Text!="")
                {
                    if (checkBoxGrayImage.Checked || checkBoxTwoPixelImage.Checked || checkBoxThreePointTrack.Checked)
                    {
                        pictureBoxShow.BackColor = Color.WhiteSmoke;
                        pictureBoxShow1.BackColor = Color.WhiteSmoke;
                        if (textBoxPictureWidth.Text != "" && textBoxPictureHeight.Text != "")
                        {
                            MyImage.width = int.Parse(textBoxPictureWidth.Text);
                            MyImage.height = int.Parse(textBoxPictureHeight.Text);
                            MyImage.image_byte_length = MyImage.width * MyImage.height;
                            if (checkBoxTwoPixelImage.Checked)
                            {
                                MyImage.image_byte_length = MyImage.image_byte_length / 8;
                            }
                        }
                        else
                        {
                            toolStripStatusLabelMessage.Text = "亲，请输入图像高度和宽度";
                            return;
                        }
                        MyImage.image_get_flag = 0;
                    }             
                    comboBoxCom.Enabled = false;
                    comboBoxBaudRate.Enabled = false;
                    comboBoxByteSize.Enabled = false;
                    comboBoxParity.Enabled = false;
                    comboBoxStopBits.Enabled = false;
                    checkBoxGrayImage.Enabled = false;
                    checkBoxTwoPixelImage.Enabled = false;
                    checkBoxThreePointTrack.Enabled = false;
                    buttonSend.Enabled = true;
                    buttonAutoSend.Enabled = true;
                    textBoxPictureWidth.Enabled = false;
                    textBoxPictureHeight.Enabled = false;
                    buttonOpenCom.Text = "关闭串口";
                    toolStripStatusLabelMessage.Text = "串口正在使用";
                    Myserialport.PortName = comboBoxCom.Text;
                    Myserialport.BaudRate = int.Parse(comboBoxBaudRate.Text);
                    Myserialport.DataBits = int.Parse(comboBoxByteSize.Text);
                    Myserialport.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);
                    Myserialport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);
                    Myserialport.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);
                    Myserialport.ReceivedBytesThreshold = 1;//事件发生前内部输入缓冲区的字节数，每当缓冲区的字节达到此设定的值，就会触发对象的数据接收事件
                    try
                    {
                        Myserialport.Open();
                        Myserialport.DiscardInBuffer();
                    }
                    catch (Exception ee)
                    {
                        this.Invoke((EventHandler)(delegate
                        {
                            textBoxReceivingArea.Text += ee;
                        }));
                    }
                    //DealWith_Readdata_thread.Priority = ThreadPriority.AboveNormal;
                    //DealWith_Readdata_thread.Start();
                }
                else
                {
                    comboBoxCom.BackColor = Color.Blue;
                    toolStripStatusLabelMessage.Text = "亲，没找到有效串口哦";
                }
            }
            else    //串口关闭
            {
                while (Read_Cache_Data_flag == 1)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
                //this.Close();
                //DealWith_Readdata_thread.Abort();
                //Com_Using.DiscardInBuffer();
                Myserialport.Close(); 
                comboBoxCom.Enabled = true;
                comboBoxBaudRate.Enabled = true;
                comboBoxByteSize.Enabled = true;
                comboBoxParity.Enabled = true;
                comboBoxStopBits.Enabled = true;
                checkBoxGrayImage.Enabled = true;
                checkBoxTwoPixelImage.Enabled = true;
                checkBoxThreePointTrack.Enabled = true;
                buttonOpenCom.Text = "打开串口";
                toolStripStatusLabelMessage.Text = "串口未打开";
                buttonSend.Enabled = false;
                buttonAutoSend.Enabled = false;
                textBoxPictureWidth.Enabled = true;
                textBoxPictureHeight.Enabled = true;
                pictureBoxShow.Visible = true;
                pictureBoxShow1.Visible = false;
                MyImage.image_get_flag = 0;
            }
            if (open_SerialPort_flag == 2)
                open_SerialPort_flag = 0;
            ComPort_closing = 0;
        }
        //数据接收使用的代理
        //private delegate void myDelegate(string s);

        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //----------获取串口数据------------//
            if (Myserialport.IsOpen == true)
            {
                if (ComPort_closing==1)
                {
                    return;
                }
                Read_Cache_Data_flag = 1 ;
                byte[] Cachedata = new byte[Myserialport.BytesToRead];
                Myserialport.Read(Cachedata, 0, Cachedata.Length);
                foreach (byte data_temp in Cachedata)
                {
                    Deal_PortData(data_temp);
                }
                Read_Cache_Data_flag = 0;
            }
        }

        
        public void Deal_PortData(byte data)
        {
            if (checkBoxGrayImage.Checked || checkBoxTwoPixelImage.Checked || checkBoxThreePointTrack.Checked || checkBoxWaveImage.Checked)
            {
                //------------接收图像数据------------//
                if (MyImage.image_get_flag != 4)
                {
                    MyImage.GetImageFramehead_Deal(data);
                }
                else //采集图像
                {
                    if (checkBoxTwoPixelImage.Checked)    //鹰眼压缩图像模式
                    {
                        MyImage.TwoPixelImage_Deal(data);
                        if (MyImage.TwoPixelImage_finish_flag == 1)
                        {
                            this.Invoke((EventHandler)(delegate
                            {
                                pictureBoxShow.Refresh();
                                if (checkBoxAutoSaveImage.Checked)
                                {
                                    string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                                    pictureBoxShow.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                                    toolStripStatusLabelMessage.Text = Image_save_name + "保存成功";
                                    Image_save_Num++;
                                }
                            }));
                            MyImage.TwoPixelImage_finish_flag = 0;
                        }
                    
                    }
                    else if (checkBoxThreePointTrack.Checked )   //三点赛道模式
                    {
                        MyImage.ThreePointTrack_Deal(data);
                        if(MyImage.ThreePointTrack0_finish_flag ==1)
                        {
                            this.Invoke((EventHandler)(delegate
                            {
                                pictureBoxShow.Visible = true;
                                pictureBoxShow.Refresh();
                                if (checkBoxAutoSaveImage.Checked)
                                {
                                    string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                                    pictureBoxShow.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                                    toolStripStatusLabelMessage.Text = Image_save_name + "保存成功";
                                    Image_save_Num++;
                                }
                                MyImage.camera_image_gra1.Clear(Color.WhiteSmoke);
                                pictureBoxShow1.Visible = false;
                            }));
                            MyImage.ThreePointTrack0_finish_flag = 0;
                        }
                        else if(MyImage.ThreePointTrack1_finish_flag ==1)
                        {
                            this.Invoke((EventHandler)(delegate
                            {
                                pictureBoxShow1.Visible = true;
                                pictureBoxShow1.Refresh();
                                if (checkBoxAutoSaveImage.Checked)
                                {
                                    string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                                    pictureBoxShow1.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                                    toolStripStatusLabelMessage.Text = Image_save_name + "保存成功";
                                    Image_save_Num++;
                                }
                                MyImage.camera_image_gra.Clear(Color.WhiteSmoke);
                                pictureBoxShow.Visible = false;
                            }));
                            MyImage.ThreePointTrack1_finish_flag = 0;
                        }
                    }
                    else if(checkBoxWaveImage.Checked)
                    {
                        if (MyImage.waveimage_flag < 0)
                        {
                            fr_wave.Draw_Wave(data);
                            MyImage.waveimage_flag = 10;
                        }
                        else
                        {
                            MyImage.ThreePointTrack_Deal(data);
                            if (MyImage.ThreePointTrack0_finish_flag == 1)
                            {
                                this.Invoke((EventHandler)(delegate
                                {
                                    pictureBoxShow.Visible = true;
                                    pictureBoxShow.Refresh();
                                    if (checkBoxAutoSaveImage.Checked)
                                    {
                                        string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                                        pictureBoxShow.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                                        toolStripStatusLabelMessage.Text = Image_save_name + "保存成功";
                                        Image_save_Num++;
                                    }
                                    MyImage.camera_image_gra1.Clear(Color.WhiteSmoke);
                                    pictureBoxShow1.Visible = false;
                                }));
                                MyImage.ThreePointTrack0_finish_flag = 0;
                            }
                            else if (MyImage.ThreePointTrack1_finish_flag == 1)
                            {
                                this.Invoke((EventHandler)(delegate
                                {
                                    pictureBoxShow1.Visible = true;
                                    pictureBoxShow1.Refresh();
                                    if (checkBoxAutoSaveImage.Checked)
                                    {
                                        string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                                        pictureBoxShow1.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                                        toolStripStatusLabelMessage.Text = Image_save_name + "保存成功";
                                        Image_save_Num++;
                                    }
                                    MyImage.camera_image_gra.Clear(Color.WhiteSmoke);
                                    pictureBoxShow.Visible = false;
                                }));
                                MyImage.ThreePointTrack1_finish_flag = 0;
                            }
                        }
                    }
                    else   //灰度图像
                    {
                        MyImage.GrayImage_Deal(data);
                        if (MyImage.grayImage_finish_flag == 1)
                        {
                            this.Invoke((EventHandler)(delegate
                            {
                                pictureBoxShow.Refresh();
                                if (checkBoxAutoSaveImage.Checked)
                                {
                                    string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                                    pictureBoxShow.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                                    toolStripStatusLabelMessage.Text = Image_save_name + "保存成功";
                                    Image_save_Num++;
                                }
                            }));
                            MyImage.grayImage_finish_flag = 0;
                        }
                    }
                }
            }
            else if(checkBoxIsWave.Checked)
            {
                //-------------------接收波形图数据------------------//
                fr_wave.Draw_Wave(data);
            }
            else
            {
                //------------接收纯文本数据------------//
                byte[] Resoursedata={data};
                StringBuilder readstr = new StringBuilder();
                if (checkBoxHexShow.Checked == true)
                {
                    readstr.Append(string.Format("{0:X2}", Resoursedata.ElementAt(0)));
                }
                else
                {
                    readstr.Append(System.Text.Encoding.ASCII.GetString(Resoursedata, 0, Resoursedata.Count()));
                }
                EventHandler DelUpdata = delegate
                {
                    textBoxReceivingArea.AppendText(readstr.ToString());
                    //textBoxReceivingArea.AppendText(Com_Using.BytesToRead.ToString());
                    if (checkBoxAutoClearReceivingBox.Checked == true && textBoxReceivingArea.Text.Length >= 690)
                    {
                        textBoxReceivingArea.Clear();
                    }
                };
                this.Invoke(DelUpdata);
            }
        }

        private void buttonClearReceiving_Click(object sender, EventArgs e)
        {
            textBoxReceivingArea.Clear(); 
        }

        private void buttonClearSending_Click(object sender, EventArgs e)
        {
            textBoxSendingArea.Clear();
        }

        private void checkBoxHexShow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        { 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (open_SerialPort_flag == 1)
            {
                e.Cancel = true;
                buttonOpenCom.BackColor = Color.Blue;
                toolStripStatusLabelMessage.Text = "亲，串口没关哦";
                return;
            }
            if (MessageBox.Show("将要关闭程序，是否继续？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
                //System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (Myserialport.IsOpen == true)
            {
                string sendstr = textBoxSendingArea.Text;
                if (checkBoxHexSend.Checked == true)
                {
                    byte[] b = Encoding.ASCII.GetBytes(sendstr);//按照指定编码将string编程字节数组
                    //string result = string.Empty;
                    sendstr = "";
                    for (int i = 0; i < b.Length; i++)//逐字节变为16进制字符，以%隔开
                    {
                        sendstr += " " + Convert.ToString(b[i], 16);
                    }
                }
                Myserialport.Write(sendstr);
                if (checkBoxSendEndEnter.Checked)
                {
                    Myserialport.Write("\r\n");
                }
            }
        }

        private void textBoxReceivingArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerAutoSend_Tick(object sender, EventArgs e)
        {
            buttonSend_Click(sender, e);
        }

        private void comboBoxCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCom.BackColor = Color.White;
        }

        private void textBoxReceivingArea_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxReceivingArea.Clear();
        }

        private void textBoxSendingArea_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxSendingArea.Clear();
        }

        private void textBoxSendingArea_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBoxSendingArea_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                //buttonSend_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        public static Bitmap ToGrayBitmap(byte[] rawValues, int width, int height)
        {
            //---------引用自网上一篇博客---------//
            //// 申请目标位图的变量，并将其内存区域锁定
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            //// 获取图像参数
            int stride = bmpData.Stride;    // 扫描线的宽度
            int offset = stride - width;     // 显示宽度与扫描线宽度的间隙
            IntPtr iptr = bmpData.Scan0;      // 获取bmpData的内存起始位置
            int scanBytes = stride * height;   // 用stride*宽度，表示这是内存区域的大小
            //// 下面把原始的显示大小字节数组转换为内存中实际存放的字节数组
            int posScan = 0, posReal = 0;   // 分别配置两个位置指针，指向源数组和目标数组
            byte[] pixelValues = new byte[scanBytes];  //为目标数组分配内存
            for (int x = 0; x < height; x++)
            {
                //// 下面的循环节是模拟行扫描
                 for (int y = 0; y < width; y++)
                 {
                     pixelValues[posScan++] = rawValues[posReal++];
                 }
                 //行扫描结束，要将目标位置指针移过那段“间隙” ;
                 posScan += offset;
            }
            //// 用Marshal的Copy要领，将刚才得到的内存字节数组复制到BitmapData中
            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, iptr, scanBytes);
            bmp.UnlockBits(bmpData);　 // 解锁内存区域
            //// 下面的代码是为了修改生成位图的索引表，从伪彩修改为灰度
            ColorPalette tempPalette;
            using (Bitmap tempBmp = new Bitmap(1, 1, PixelFormat.Format8bppIndexed))
            {
                tempPalette = tempBmp.Palette;
            }
             for (int i = 0; i < 256; i++)
             {
                 tempPalette.Entries[i] = Color.FromArgb(i, i, i);
             }
             bmp.Palette = tempPalette;
             //// 算法到此结束，返回结果
             return bmp;
        }

        private void pictureBoxShow_MouseMove(object sender, MouseEventArgs e)
        {
            double Pixel_x, Pixel_y;
            Pixel_x = e.X * int.Parse(textBoxPictureWidth.Text) / pictureBoxShow.Width;
            Pixel_y = e.Y * int.Parse(textBoxPictureHeight.Text) / pictureBoxShow.Height;
            if (toolTipPicColumnRow.GetToolTip(pictureBoxShow)!=(((int)(Pixel_x + 1)).ToString() + "," + ((int)(Pixel_y)).ToString()))
            {
                toolTipPicColumnRow.SetToolTip(pictureBoxShow, ((int)(Pixel_x + 1)).ToString() + "," + ((int)(Pixel_y )).ToString());
            }
        }

        private void timerFreshPort_Tick(object sender, EventArgs e)
        {
            //---------刷新串口----------//
            string[] str = SerialPort.GetPortNames();
            if (str.Length > 0)
            {
                int i;
                foreach (string s in str)
                {
                    for (i = 0; i < comboBoxCom.Items.Count; i++)
                        if (s == (string)(comboBoxCom.Items[i]))
                            break;
                    if (i == comboBoxCom.Items.Count)
                        comboBoxCom.Items.Add(s);
                }
                if (comboBoxCom.Text == "")
                    comboBoxCom.SelectedText = (string)comboBoxCom.Items[0];
            }
            else
            {
                comboBoxCom.Text = null;
                comboBoxCom.Items.Clear();
            } 
        }

        private void labelPictureHeight_Click(object sender, EventArgs e)
        {

        }

        private void buttonPictureDerectory_Click(object sender, EventArgs e)
        {
            string Picture_Dialog_path;
            folderBrowserDialogImage.ShowDialog();
            Picture_Dialog_path = folderBrowserDialogImage.SelectedPath;
            groupBoxPicConfig.Text = "保存路径:"+Picture_Dialog_path;
            Image_save_path = Picture_Dialog_path.Replace("\\", "\\\\");    //将单斜杠路径转换为双斜杠路径,引用自博客：http://blog.csdn.net/chenlunju/article/details/7615670
            //groupBoxPicConfig.Text = Image_save_path;
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            if (Image_save_path != "")
            {
                //pictureBoxShow.Image.Save("C:\\Users\\Zhu wei\\Desktop\\1.bmp",System.Drawing.Imaging.ImageFormat.Bmp);
                if (pictureBoxShow.Image != null)
                {
                    string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                    pictureBoxShow.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                    toolStripStatusLabelMessage.Text = Image_save_name+"保存成功";
                    Image_save_Num++;
                }
                else
                {
                    toolStripStatusLabelMessage.Text = "亲，没选择图片哦";
                }
            }
            else
            {
                toolStripStatusLabelMessage.Text = "亲，请先选择保存路径哦";
            }
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogImageLoad.ShowDialog() == DialogResult.OK && (openFileDialogImageLoad.FileName != ""))
            {
                pictureBoxShow.ImageLocation = openFileDialogImageLoad.FileName;
            }
        }

        private void buttonAutoShowImage_Click(object sender, EventArgs e)
        {
            buttonAutoShowImage_flag++;
            if (buttonAutoShowImage_flag == 1)
            {
                folderBrowserDialogImage.ShowDialog();
                if (folderBrowserDialogImage.ShowDialog() == DialogResult.OK)
                {
                    listBoxImageList.Items.Clear();
                    string[] tmp1 = System.IO.Directory.GetFiles(folderBrowserDialogImage.SelectedPath, "*.bmp ");
                    Array.Sort(tmp1);
                    foreach(string s in tmp1)
                    {
                        listBoxImageList.Items.Add(new FileInfo(s).Name);
                    }                    
                    listBoxImageList.Enabled = true;
                    listBoxImageList.Visible = true;
                    listBoxImageList.SelectedIndex = 0;
                    pictureBoxShow.ImageLocation =folderBrowserDialogImage.SelectedPath+"\\"+listBoxImageList.SelectedItem.ToString();
                    timerAutoShowImage.Enabled = true;
                }
                buttonAutoShowImage.Text = "停止播放";
                buttonStopShowImgTemp.Text = "暂停播放";
                labelAutoShowImageSpeed.Enabled = true;
            }
            else
            {
                timerAutoShowImage.Enabled = false;
                //listBoxImageList.Items.Clear();
                //listBoxImageList.Enabled = false;
                listBoxImageList.Items.Clear();
                listBoxImageList.Enabled = false;
                listBoxImageList.Visible = false;
                buttonAutoShowImage.Text = "自动播放";
                buttonStopShowImgTemp.Text = "暂停播放";
                labelAutoShowImageSpeed.Enabled = false;
                Image_laod_Num = 0;
            }
            if(buttonAutoShowImage_flag==2)
            {
                buttonAutoShowImage_flag = 0;
            }
        }

        private void timerAutoShowImage_Tick(object sender, EventArgs e)
        {
            listBoxImageList.SelectedIndex = Image_laod_Num;
            pictureBoxShow.ImageLocation = folderBrowserDialogImage.SelectedPath + "\\" + listBoxImageList.SelectedItem.ToString();
            Image_laod_Num++;
            if(Image_laod_Num==listBoxImageList.Items.Count)
            {
                Image_laod_Num = 0;
            }
        }

        private void labelAutoShowImageSpeed_Click(object sender, EventArgs e)
        {
            timerAutoShowImage.Enabled = false;
            int  timerAutoShowImage_interval;
            Point Mouse_Position_in_lable = labelAutoShowImageSpeed.PointToClient(MousePosition);
            timerAutoShowImage_interval = Mouse_Position_in_lable.X * 1000/labelAutoShowImageSpeed.Width;
            if (timerAutoShowImage_interval < 5)
                timerAutoShowImage_interval = 5;
            timerAutoShowImage.Interval = timerAutoShowImage_interval;
            timerAutoShowImage.Enabled = true;
            //toolStripStatusLabel2.Text = Convert.ToString(timerAutoShowImage_interval);
        }

        private void labelAutoShowImageSpeed_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void labelAutoShowImageSpeed_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureBoxShow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // pictureBoxShow.Image = null;
            //Com_Using.DiscardInBuffer();
            MyImage.image_get_flag = 0;
        }

        private void listBoxImageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxShow.ImageLocation = folderBrowserDialogImage.SelectedPath + "\\" + listBoxImageList.SelectedItem.ToString();
            Image_laod_Num = listBoxImageList.SelectedIndex;
        }

        private void listBoxImageList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBoxImageList.Items.Clear();
            listBoxImageList.Enabled = false;
            listBoxImageList.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBoxImageList.Visible)
            {
                if(timerAutoShowImage.Enabled)
                {
                    timerAutoShowImage.Enabled = false;
                    buttonStopShowImgTemp.Text = "继续播放";
                }
                else
                {
                    timerAutoShowImage.Enabled = true;
                    buttonStopShowImgTemp.Text = "暂停播放";
                }
            }
        }
        
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void 更新说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxReceivingArea.Text = "1.新增波形图功能，可以单独看曲线或同时看曲线和图像\r\n\r\n2.新增注册程序和注册机\r\n\r\n3.优化界面，增加显示时间和进度条";         
        }

        private void checkBoxTwoPixelImage_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTwoPixelImage.Checked)
            {
                pictureBoxShow.Visible = true;
                pictureBoxShow1.Visible = false;
            }
        }

        private void checkBoxGrayImage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrayImage.Checked)
            {
                pictureBoxShow.Visible = true;
                pictureBoxShow1.Visible = false;
            }
        }

        private void ToolStripMenuItemCommunicationAgreement_Click(object sender, EventArgs e)
        {
            textBoxReceivingArea.Text = "灰度图像：\r\n\r\n uint8 frame_head[]={1,254,254,1};\r\n uart_putbuff(UARTn,frame_head,4);\r\n uart_putbuff(UARTn,image,image_size);\r\n\r\n鹰眼二值化(压缩图像)：\r\n 同灰度图像\r\n\r\n三点赛道：\r\n uint8 frame_head[]={1,254,254,1};\r\n uart_putbuff(UARTn,frame_head,4);\r\n uart_putchar(UARTn,effective_line);\r\n for(int i=0;i<picture_height;i++){\r\n uart_putchar(UARTn,left_line[i];\r\n uart_putchar(UARTn,center_line[i];\r\n uart_putchar(UARTn,right_line[i];}\r\n\r\n速度曲线加三点赛道：\r\n 在三点赛道的通信协议中的发送有效行之前发送速度即可";
        }

        private void goldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
            my_file.Write_Log_FormMain_BackColor(Color.Gold.ToArgb().ToString() + "         ");
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            my_file.Write_Log_FormMain_BackColor(Color.Red.ToArgb().ToString() + "         ");
        }

        private void oringeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            my_file.Write_Log_FormMain_BackColor(Color.Orange.ToArgb().ToString() + "         ");
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            my_file.Write_Log_FormMain_BackColor(Color.Yellow.ToArgb().ToString() + "         ");
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor =Color.FromArgb(0,192,0);
            my_file.Write_Log_FormMain_BackColor(Color.FromArgb(0, 192, 0).ToArgb().ToString() + "         ");
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            my_file.Write_Log_FormMain_BackColor(Color.Gray.ToArgb().ToString() + "         ");
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            my_file.Write_Log_FormMain_BackColor(Color.Blue.ToArgb().ToString() + "          ");
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
            my_file.Write_Log_FormMain_BackColor(Color.LightPink.ToArgb().ToString() + "         ");
        }

        private void whitesmokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            my_file.Write_Log_FormMain_BackColor(Color.WhiteSmoke.ToArgb().ToString() + "         ");
        }

        private void textBoxPictureWidth_TextChanged(object sender, EventArgs e)
        {
            my_file.Write_String("Image_Width.txt", textBoxPictureWidth.Text);
        }

        private void textBoxPictureHeight_TextChanged(object sender, EventArgs e)
        {
            my_file.Write_String("Image_Height.txt", textBoxPictureHeight.Text);
        }

        private void picturegridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyImage.picturegrid_flag == 0)
            {
                MyImage.picturegrid_flag = 1;
            }
            else
            {
                MyImage.picturegrid_flag = 0;
            } 
        }

        private void checkBoxIsWave_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxIsWave.Checked)
            {
                fr_wave.Show();
            }
        }

        private void checkBoxSyetemTime_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSyetemTime.Checked)
            {
                toolStripStatusLabelTime.Text = "当前时间：" + DateTime.Now.ToString();
            }
            else
            {
                toolStripStatusLabelTime.Text = "";
            }
        }

        private void pictureBoxShow1_MouseMove(object sender, MouseEventArgs e)
        {
            double Pixel_x, Pixel_y;
            Pixel_x = e.X * int.Parse(textBoxPictureWidth.Text) / pictureBoxShow.Width;
            Pixel_y = e.Y * int.Parse(textBoxPictureHeight.Text) / pictureBoxShow.Height;
            if (toolTipPicColumnRow.GetToolTip(pictureBoxShow) != (((int)(Pixel_x + 1)).ToString() + "," + ((int)(Pixel_y)).ToString()))
            {
                toolTipPicColumnRow.SetToolTip(pictureBoxShow, ((int)(Pixel_x + 1)).ToString() + "," + ((int)(Pixel_y)).ToString());
            }
        }

        private void checkBoxWaveImage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWaveImage.Checked)
            {
                fr_wave.Show();
            }
        }

        private void tCPClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wifi_mode = 2;
            groupBoxInitialization.Visible = false;
            buttonOpenCom.Visible = false;
            groupBoxWifiSettings.Visible = true;
            textBoxLocalIP.Enabled = false;
            textBoxLocalPortNum.Enabled = false;
            textBoxMaxClientNum.Enabled = false;
            textBoxServerIP.Enabled = true;
            textBoxServerPortNum.Enabled = true;
            buttonWifiStart.Visible = true;
            buttonWifiStart.Enabled = true;
            buttonWifiStop.Visible = true;
            buttonWifiStop.Enabled = false;
            buttonWifiStart.Text = "连接";
            textBoxServerIP.Text = "192.168.191.2";
            textBoxServerPortNum.Text = "5001";
        }

        private void tCPServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wifi_mode = 1;
            groupBoxInitialization.Visible = false;
            buttonOpenCom.Visible = false;
            groupBoxWifiSettings.Visible = true;
            textBoxLocalIP.Enabled = true;
            textBoxLocalPortNum.Enabled = true;
            textBoxMaxClientNum.Enabled = true;
            textBoxServerIP.Enabled = false;
            textBoxServerPortNum.Enabled = false;
            buttonWifiStart.Visible = true;
            buttonWifiStart.Enabled = true;
            buttonWifiStop.Visible = true;
            buttonWifiStop.Enabled = false;
            buttonWifiStart.Text = "监听";
            System.Net.IPHostEntry myEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            string ipAddress = myEntry.AddressList[0].ToString();
            textBoxLocalIP.Text = "192.168.1.1";
            textBoxLocalPortNum.Text = "6000";
            textBoxMaxClientNum.Text = "10";
        }

        private void ToolStripMenuItemSerialPort_Click(object sender, EventArgs e)
        {
            groupBoxInitialization.Visible = true;
            buttonOpenCom.Visible = true;
            buttonWifiStart.Visible = false;
            buttonWifiStop.Visible = false;
        }

        private int wifi_mode=0;  //1-TCP_sever,2-TCP_client,3-UDP_sever,4-UDP_client
        private IPAddress serverIP = IPAddress.Parse("192.168.1.1");
        private IPAddress localIP = IPAddress.Parse("192.168.1.1");
        private IPEndPoint serverFullAddr;//完整终端地址
        private IPEndPoint localFullAddr;//完整终端地址
        private Socket TCP_socket;
        private Thread Client_Receive_thread;
        private Thread Sever_Receive_thread;
        private void buttonWifiStart_Click(object sender, EventArgs e)
        {
            if (wifi_mode==2)    //TCP客户端模式
            {
                serverIP = IPAddress.Parse(textBoxServerIP.Text);
                try
                {
                    serverFullAddr = new IPEndPoint(serverIP, int.Parse(textBoxServerPortNum.Text));//设置IP，端口
                    TCP_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    TCP_socket.Connect(serverFullAddr);
                    toolStripStatusLabelMessage.Text = "连接TCP服务器成功。。。。";
                    buttonWifiStart.Enabled = false;
                    buttonWifiStop.Enabled = true;
                    Client_Receive_thread = new System.Threading.Thread(client_receive_data);
                    Client_Receive_thread.Start();
                }
                catch (Exception ee)
                {
                    textBoxReceivingArea.Text += "连接服务器失败。。。请仔细检查服务器是否开启" + ee;
                }
            }
            else if (wifi_mode == 3)    //UDP服务器模式
            {
                localIP = IPAddress.Parse(textBoxLocalIP.Text);
                try
                {
                    localFullAddr = new IPEndPoint(localIP, int.Parse(textBoxLocalPortNum.Text));//设置IP，端口
                    UDP_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    UDP_socket.Bind(localFullAddr);
                    toolStripStatusLabelMessage.Text = "监听成功。。。。";
                    buttonWifiStart.Enabled = false;
                    buttonWifiStop.Enabled = true;
                    Sever_Receive_thread = new System.Threading.Thread(sever_receive_data);
                    Sever_Receive_thread.Start();
                }
                catch (Exception ee)
                {
                    textBoxReceivingArea.Text += "监听失败" + ee;
                }
            }
            else if (wifi_mode==4)   //udp客户端
            {
                serverIP = IPAddress.Parse(textBoxServerIP.Text);
                try
                {
                    serverFullAddr = new IPEndPoint(serverIP, int.Parse(textBoxServerPortNum.Text));//设置IP，端口
                    UDP_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    UDP_socket.Connect(serverFullAddr);
                    toolStripStatusLabelMessage.Text = "连接UDP服务器成功。。。。";
                    Remote = (EndPoint)(serverFullAddr);
                    buttonWifiStart.Enabled = false;
                    buttonWifiStop.Enabled = true;
                    Client_Receive_thread = new System.Threading.Thread(client_receive_data);
                    Client_Receive_thread.Start();
                }
                catch (Exception ee)
                {
                    textBoxReceivingArea.Text += "连接服务器失败。。。请仔细检查服务器是否开启" + ee;
                }
            }
        }

        public void sever_receive_data()
        {
            byte[] recei_data = new byte[65536];
            if(wifi_mode==3)
            {
                while(true)
                {
                    if(UDP_socket.IsBound)
                    {
                        try
                        {
                            int len = UDP_socket.Receive(recei_data);
                            if (len > 0)
                            {
                                for (int i = 0; i < len; i++)
                                {
                                    Deal_PortData(recei_data[i]);
                                }
                            }
                        }
                        catch (Exception ee)
                        {

                        }
                    }
                }
            }
        }

        private EndPoint Remote ;
        public void client_receive_data()
        {
            byte[] recei_data = new byte[65536];
            //TCP_socket.ReceiveTimeout = 3000; 
            if (wifi_mode == 2)
            {
                while (true)
                {
                    if (TCP_socket.Connected)
                    {
                        try
                        {
                            int len = TCP_socket.Receive(recei_data);
                            /* this.Invoke((EventHandler)(delegate
                            {
                                textBoxReceivingArea.Text += "  len=" + len.ToString();
                            }));*/
                            if (len > 0)
                            {
                                for (int i = 0; i < len; i++)
              
                                {
                                    Deal_PortData(recei_data[i]);
                                }
                            }
                        }
                        catch (Exception ee)
                        {
                            this.Invoke((EventHandler)(delegate
                            {
                                textBoxReceivingArea.Text += "连接服务器失败。。。请仔细检查服务器是否开启" + ee;
                            }));
                        }
                    }
                }
            }
            else if (wifi_mode == 4)
            {
                while (true)
                {
                    if (UDP_socket.Connected)
                    {
                        try
                        {
                            int len = UDP_socket.Receive(recei_data);// ReceiveFrom(recei_data, ref Remote);
                            if (len > 0)
                            {
                                this.Invoke((EventHandler)(delegate
                                {
                                    textBoxReceivingArea.Text += "接收到数据";
                                }));
                                for (int i = 0; i < len; i++)
                                {
                                    Deal_PortData(recei_data[i]);
                                }
                            }
                        }
                        catch (Exception ee)
                        {
                            this.Invoke((EventHandler)(delegate
                            {
                                textBoxReceivingArea.Text += "连接服务器失败。。。请仔细检查服务器是否开启" + ee;
                            }));
                        }
                    }
                }
            }
        }

        private void buttonWifiStop_Click(object sender, EventArgs e)
        {
            if (wifi_mode == 2)
            {
                TCP_socket.Close();
                Client_Receive_thread.Abort();
            }
            else if(wifi_mode ==3)
            {
                UDP_socket.Close();
                Sever_Receive_thread.Abort();
            }
            else if (wifi_mode == 4)
            {
                UDP_socket.Close();
                Client_Receive_thread.Abort();
            }
            toolStripStatusLabelMessage.Text = "已断开连接。。。。";
            buttonWifiStart.Enabled = true;
            buttonWifiStop.Enabled = false;
            
        }

        private Socket UDP_socket;
        private void uDPClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wifi_mode = 4;
            groupBoxInitialization.Visible = false;
            buttonOpenCom.Visible = false;
            groupBoxWifiSettings.Visible = true;
            textBoxLocalIP.Enabled = false;
            textBoxLocalPortNum.Enabled = false;
            textBoxMaxClientNum.Enabled = false;
            textBoxServerIP.Enabled = true;
            textBoxServerPortNum.Enabled = true;
            buttonWifiStart.Visible = true;
            buttonWifiStart.Enabled = true;
            buttonWifiStop.Visible = true;
            buttonWifiStop.Enabled = false;
            buttonWifiStart.Text = "连接";
            textBoxServerIP.Text = "192.168.191.5";
            textBoxServerPortNum.Text = "5001";
        }

        /*private void uDPSeverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }*/

        private void uDPSeverToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            wifi_mode = 3;
            groupBoxInitialization.Visible = false;
            buttonOpenCom.Visible = false;
            groupBoxWifiSettings.Visible = true;
            textBoxLocalIP.Enabled = true;
            textBoxLocalPortNum.Enabled = true;
            textBoxMaxClientNum.Enabled = true;
            textBoxServerIP.Enabled = false;
            textBoxServerPortNum.Enabled = false;
            buttonWifiStart.Visible = true;
            buttonWifiStart.Enabled = true;
            buttonWifiStop.Visible = true;
            buttonWifiStop.Enabled = false;
            buttonWifiStart.Text = "监听";
            //System.Net.IPHostEntry myEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            //string ipAddress = myEntry.AddressList[0].ToString();
            textBoxLocalIP.Text = "192.168.191.1";
            textBoxLocalPortNum.Text = "5001";
            textBoxMaxClientNum.Text = "10";
        }
    }
}
