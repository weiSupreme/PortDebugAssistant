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
//using System.Collections;

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
        //private int abc = 0;
        Bitmap camera_image_bit = new Bitmap(640, 480);
        private SerialPortDebug.FormWave fr_wave = new FormWave();
        private SerialPortDebug.MyFile my_file = new MyFile();

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
                    toolStripStatusLabel2.Text = "亲，未输入发送间隔时间哦。";
                }
                else
                {
                    timerAutoSend.Interval = Convert.ToInt32(textBoxTimeMs.Text);
                    timerAutoSend.Enabled = true;
                    textBoxTimeMs.Enabled = false;
                    buttonAutoSend.Text = "停止发送";
                    toolStripStatusLabel2.Text = "正在自动发送";
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

        private void Form1_Load(object sender, EventArgs e)
        {
            int image_width, image_height;
            Color back_form_color = new Color();
            back_form_color=my_file.Read_Log_FormMian_BackColor();
            this.BackColor = back_form_color;
            image_width = my_file.SetImage_Width();
            image_height = my_file.SetImage_Height();
            this.DoubleBuffered = true;
            Serialport.Init_Serialport();
            
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
                            toolStripStatusLabel2.Text = "亲，请输入图像高度和宽度";
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
                    toolStripStatusLabel2.Text = "串口正在使用";
                    Myserialport.PortName = comboBoxCom.Text;
                    Myserialport.BaudRate = int.Parse(comboBoxBaudRate.Text);
                    Myserialport.DataBits = int.Parse(comboBoxByteSize.Text);
                    Myserialport.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);
                    Myserialport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);
                    Myserialport.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);
                    Myserialport.ReceivedBytesThreshold = 1;//事件发生前内部输入缓冲区的字节数，每当缓冲区的字节达到此设定的值，就会触发对象的数据接收事件
                    Myserialport.Open();
                    Myserialport.DiscardInBuffer();
                    //DealWith_Readdata_thread.Priority = ThreadPriority.AboveNormal;
                    //DealWith_Readdata_thread.Start();
                }
                else
                {
                    comboBoxCom.BackColor = Color.Blue;
                    toolStripStatusLabel2.Text = "亲，没找到有效串口哦";
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
                toolStripStatusLabel2.Text = "串口未打开";
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
            if (checkBoxGrayImage.Checked || checkBoxTwoPixelImage.Checked || checkBoxThreePointTrack.Checked)
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
                    }
                    else if (checkBoxThreePointTrack.Checked)   //三点赛道模式
                    {
                        MyImage.ThreePointTrack_Deal(data);
                    }
                    else
                    {
                        MyImage.GrayImage_Deal(data);
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
                toolStripStatusLabel2.Text = "亲，串口没关哦";
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
            string sendstr = textBoxSendingArea.Text;
            if (checkBoxHexSend.Checked==true)
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
            if(checkBoxSendEndEnter.Checked)
            {
                Myserialport.Write("\r\n");
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
            MyImage.Image_save_path = Picture_Dialog_path.Replace("\\", "\\\\");    //将单斜杠路径转换为双斜杠路径,引用自博客：http://blog.csdn.net/chenlunju/article/details/7615670
            //groupBoxPicConfig.Text = Image_save_path;
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            if (MyImage.Image_save_path != "")
            {
                //pictureBoxShow.Image.Save("C:\\Users\\Zhu wei\\Desktop\\1.bmp",System.Drawing.Imaging.ImageFormat.Bmp);
                if (pictureBoxShow.Image != null)
                {
                    string Image_save_name = Convert.ToString(MyImage.Image_save_Num) + ".bmp";
                    pictureBoxShow.Image.Save(MyImage.Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                    toolStripStatusLabel2.Text = Image_save_name+"保存成功";
                    MyImage.Image_save_Num++;
                }
                else
                {
                    toolStripStatusLabel2.Text = "亲，没选择图片哦";
                }
            }
            else
            {
                toolStripStatusLabel2.Text = "亲，请先选择保存路径哦";
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
                    /*string[] tmp2=new string[tmp1.Count()];
                    for (UInt32 i = 0; i < tmp1.Count(); i++)
                    {
                        tmp1[i] = tmp2[i];
                    }
                    for (UInt32 i = 0; i < tmp1.Count()-1;i++ )
                    {
                        for(UInt32 j=0;j<tmp1.Count()-i-1;j++)
                        {
                            if(string.Compare(tmp1[j],tmp1[j+1])<0)
                            {
                                string empty = tmp1[j];
                                tmp1[j] = tmp1[j + 1];
                                tmp1[j + 1] = empty;
                            }
                        }
                        //tmp2[i]=new FileInfo(tmp1[i]).Name;
                    }
                    //Array.Sort(tmp2);*/
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
            textBoxReceivingArea.Text = "1.\r\n\r\n";         
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
            textBoxReceivingArea.Text = "灰度图像：\r\n\r\n uint8 frame_head[]={1,254,254,1};\r\n uart_putbuff(UARTn,frame_head,4);\r\n uart_putbuff(UARTn,image,image_size);\r\n\r\n鹰眼二值化(压缩图像)：\r\n 同灰度图像\r\n\r\n三点赛道：\r\n uint8 frame_head[]={1,254,254,1};\r\n uart_putbuff(UARTn,frame_head,4);\r\n uart_putchar(UARTn,effective_line);\r\n for(int i=0;i<picture_height;i++){\r\n uart_putchar(UARTn,left_line[i];\r\n uart_putchar(UARTn,center_line[i];\r\n uart_putchar(UARTn,right_line[i];}";
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
            my_file.Save_HeightorWidth("Image_Width.txt", textBoxPictureWidth.Text);
        }

        private void textBoxPictureHeight_TextChanged(object sender, EventArgs e)
        {
            my_file.Save_HeightorWidth("Image_Height.txt", textBoxPictureHeight.Text);
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
                //fr_wave.Show();
            }
        }
    }
}
