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
        private int height = 40, width = 140;    //图像高度和宽度
        private int image_byte_length = 0;
        private uint image_get_flag = 0;      //采集图像数据标志位
        private string Image_save_path;            //保存图片路径字符串
        private UInt32 Image_save_Num=1;          //保存图片时的名字变量
        private int Image_laod_Num = 0;        //自动播放图片序列
        private uint buttonAutoShowImage_flag=0;    //自动播放图片按钮标志位
        //private int abc = 0;
        Bitmap camera_image_bit = new Bitmap(640, 480);
        private Graphics camera_image_gra;
        private Graphics camera_image_gra1;
        private int image_row_count = 0;
        private int image_column_count = 0;
        private int three_point_track_dist_flag = 0;    //三点赛道模式标志位
        private int picturebox_who_flag=0;
        private int effective_line = -5;        //三点赛道模式下的有效行
        private int picturegrid_flag = 0;
        private SerialPortDebug.FormWave fr_wave = new FormWave();

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

        public void Read_Log_FormMian_BackColor()
        {
            string path = Application.StartupPath + "\\SystemLog\\" + "FormMain_BackColor.txt";
            if (File.Exists(path))
            {
                byte[] byData = new Byte[100];
                FileStream file = new FileStream(path, FileMode.Open);
                file.Seek(0, SeekOrigin.Begin);
                file.Read(byData, 0, 100); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,
                                  //它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
                string str_color = System.Text.Encoding.ASCII.GetString(byData, 0, byData.Count());
                this.BackColor = Color.FromArgb(Convert.ToInt32(str_color));
                file.Close();
            }
        }

        public int SetImage_Width()
        {
            string path = Application.StartupPath + "\\SystemLog\\" + "Image_Width.txt";
            if (File.Exists(path))
            {
                byte[] byData = new Byte[100];
                FileStream file = new FileStream(path, FileMode.Open);
                file.Seek(0, SeekOrigin.Begin);
                file.Read(byData, 0, 100); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,
                                 //它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
                file.Close();
                int str_width = int.Parse(System.Text.Encoding.ASCII.GetString(byData, 0, byData.Count()));
                if(str_width!=0)
                {
                    return str_width;
                }
                else
                {
                    return 80;
                }
            }
            else
            {
                return 80;
            }
        }

        public int SetImage_Height()
        {
            string path = Application.StartupPath + "\\SystemLog\\" + "Image_Height.txt";
            if (File.Exists(path))
            {
                byte[] byData = new Byte[100];
                FileStream file = new FileStream(path, FileMode.Open);
                file.Seek(0, SeekOrigin.Begin);
                file.Read(byData, 0, 100); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,
                                 //它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
                file.Close();
                int str_height = int.Parse(System.Text.Encoding.ASCII.GetString(byData, 0, byData.Count()));
                if (str_height != 0)
                {
                    return str_height;
                }
                else
                {
                    return 60;
                }
            }
            else
            {
                return 60;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int image_width, image_height;
            Read_Log_FormMian_BackColor();
            image_width=SetImage_Width();
            image_height=SetImage_Height();
            this.DoubleBuffered = true;
            //---------获取串口号--------//
            string[] str = SerialPort.GetPortNames();
            if(str.Length>0)
            {
                comboBoxCom.SelectedText = str[0];
                foreach(string s in str)
                    comboBoxCom.Items.Add(s);
            }
            //--------选择波特率--------//
            int[] BaudRates={9600,19200,38400,56000,57600,115200,128000,256000};
            comboBoxBaudRate.SelectedText = "115200";
            foreach (int baudrate in BaudRates)
                comboBoxBaudRate.Items.Add(baudrate);
            //--------选择数据位--------//
            int[] bytesizes = { 5, 6, 7, 8 };
            comboBoxByteSize.SelectedText = "8";
            foreach (int bytesize in bytesizes)
                comboBoxByteSize.Items.Add(bytesize);
            //--------选择校验位-------//
            int[] parities = { 0, 1, 2 };
            comboBoxParity.SelectedText = "0";
            foreach (int parity in parities)
                comboBoxParity.Items.Add(parity);
            //---------选择停止位---------//
            int[] stopbits = { 1, 2 };
            comboBoxStopBits.SelectedText = "1";
            foreach (int stopbit in stopbits)
                comboBoxStopBits.Items.Add(stopbit);
            //Control.CheckForIllegalCrossThreadCalls = false; 
            
            buttonSend.Enabled = false;
            buttonAutoSend.Enabled = false;
            Com_Using.ReadBufferSize = 4096;
            //textBoxReceivingArea.Text=Com_Using.ReadBufferSize.ToString();
            timerFreshPort.Interval = 500;
            textBoxPictureWidth.Text = Convert.ToString(image_width);
            textBoxPictureHeight.Text = Convert.ToString(image_height);
            timerFreshPort.Enabled = true;
            pictureBoxShow.Image = camera_image_bit;
            pictureBoxShow1.Image = camera_image_bit;
            camera_image_gra = Graphics.FromImage(pictureBoxShow.Image);
            camera_image_gra1 = Graphics.FromImage(pictureBoxShow1.Image);
            //camera_image_gra.InterpolationMode =(InterpolationMode) CompositingQuality.HighQuality;
            camera_image_gra.Clear(Color.Transparent);
            camera_image_gra1.Clear(Color.Transparent);
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
                            width = int.Parse(textBoxPictureWidth.Text);
                            height = int.Parse(textBoxPictureHeight.Text);
                            image_byte_length = width * height;
                            if (checkBoxTwoPixelImage.Checked)
                            {
                                image_byte_length = image_byte_length / 8;
                            }
                        }
                        else
                        {
                            toolStripStatusLabel2.Text = "亲，请输入图像高度和宽度";
                            return;
                        }
                        image_get_flag = 0;
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
                    Com_Using.PortName = comboBoxCom.Text;
                    Com_Using.BaudRate = int.Parse(comboBoxBaudRate.Text);
                    Com_Using.DataBits = int.Parse(comboBoxByteSize.Text);
                    Com_Using.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);
                    Com_Using.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);
                    Com_Using.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);
                    Com_Using.ReceivedBytesThreshold = 1;//事件发生前内部输入缓冲区的字节数，每当缓冲区的字节达到此设定的值，就会触发对象的数据接收事件
                    Com_Using.Open();
                    Com_Using.DiscardInBuffer();
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
                Com_Using.Close(); 
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
                image_get_flag = 0;
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
            if (Com_Using.IsOpen == true)
            {
                if (ComPort_closing==1)
                {
                    return;
                }
                Read_Cache_Data_flag = 1 ;
                byte[] Cachedata = new byte[Com_Using.BytesToRead];
                Com_Using.Read(Cachedata, 0, Cachedata.Length);
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
                if(image_get_flag!=4)
                {
                    GetImageFramehead_Deal(data);
                }
                else //采集图像
                {
                    if (checkBoxTwoPixelImage.Checked)    //鹰眼压缩图像模式
                    {
                        TwoPixelImage_Deal(data);
                    }
                    else if (checkBoxThreePointTrack.Checked)   //三点赛道模式
                    {
                        ThreePointTrack_Deal(data);
                    }
                    else
                    {
                        GrayImage_Deal(data);
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
/*------------------------------------------以下是图像处理部分------------------------------------------------------*/
        public void GetImageFramehead_Deal(byte data)   //获取图像帧头
        {
            if (image_get_flag == 0)
            {
                if (data == 1)   //帧头1
                {
                    image_get_flag = 1;
                }
            }
            else if (image_get_flag == 1)
            {
                if (data == 254)    //帧头2
                {
                    image_get_flag = 2;
                }
                else
                {
                    image_get_flag = 0;
                }
            }
            else if (image_get_flag == 2)
            {
                if (data == 254)    //帧头3
                {
                    image_get_flag = 3;
                }
                else
                {
                    image_get_flag = 0;
                }
            }
            else if (image_get_flag == 3)
            {
                if (data == 1)    //帧头4
                {
                    image_get_flag = 4;
                }
                else
                {
                    image_get_flag = 0;
                }
            }
        }

        public void TwoPixelImage_Deal(byte data)   //处理鹰眼二值化压缩图像
        {
            byte pixel = new byte();
            byte[] colour = { 255, 0 };
            for (int i = 7; i >= 0; i--)
            {
                pixel = colour[(data >> i) & 0x01];
                camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(pixel, pixel, pixel)), image_column_count, image_row_count, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
                if (picturegrid_flag == 0)
                {
                    camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(pixel, pixel, pixel)), image_column_count, image_row_count, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
                }
                image_column_count += pictureBoxShow.Width / width;
                if (image_column_count >= pictureBoxShow.Width)
                {
                    image_column_count = 0;
                    image_row_count += pictureBoxShow.Height / height;
                }
            }
            if (image_row_count >= pictureBoxShow.Height)
            {
                image_row_count = 0;
                image_get_flag = 0;
                this.Invoke((EventHandler)(delegate
                {
                    pictureBoxShow.Refresh();
                    if (checkBoxAutoSaveImage.Checked)
                    {
                        string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                        pictureBoxShow.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                        toolStripStatusLabel2.Text = Image_save_name + "保存成功";
                        Image_save_Num++;
                    }
                }));
            }
        } 
         
        public void ThreePointTrack_Deal(byte data)     //三点赛道模式
        {
            if (effective_line < 0)
            {
                effective_line = data;
                image_row_count = effective_line * pictureBoxShow.Height / height + 1;
            }
            else
            {
                if (picturebox_who_flag == 0)    //使用第0个picturebox
                {
                    if (three_point_track_dist_flag == 0)   //左边界
                    {
                        camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0)), data * pictureBoxShow.Width / width, image_row_count, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
                        if (picturegrid_flag == 0)
                        {
                            camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), data * pictureBoxShow.Width / width, image_row_count, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
                        }
                        three_point_track_dist_flag = 1;
                    }
                    else if (three_point_track_dist_flag == 1)    //中线
                    {
                        camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(0, 0, 255)), data * pictureBoxShow.Width / width, image_row_count, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
                        if (picturegrid_flag == 0)
                        {
                            camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 255)), data * pictureBoxShow.Width / width, image_row_count, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
                        }
                        three_point_track_dist_flag = 2;
                    }
                    else    //右边界
                    {
                        camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0)), data * pictureBoxShow.Width / width, image_row_count, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
                        if (picturegrid_flag == 0)
                        {
                            camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), data * pictureBoxShow.Width / width, image_row_count, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
                        }
                        three_point_track_dist_flag = 0;
                        image_row_count += pictureBoxShow.Height / height;
                        if (image_row_count >= pictureBoxShow.Height)
                        {
                            image_row_count = 0;
                            image_get_flag = 0;
                            for (int i = 0; i < pictureBoxShow.Width; i += pictureBoxShow.Width / width)
                            {
                                camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(0, 0, 0)), i, effective_line * pictureBoxShow.Height / height, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
                                if (picturegrid_flag == 0)
                                {
                                    camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0)), i, effective_line * pictureBoxShow.Height / height, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
                                }
                            }
                            effective_line = -5;
                            this.Invoke((EventHandler)(delegate
                            {
                                pictureBoxShow.Visible = true;
                                pictureBoxShow.Refresh();
                                if (checkBoxAutoSaveImage.Checked)
                                {
                                    string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                                    pictureBoxShow.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                                    toolStripStatusLabel2.Text = Image_save_name + "保存成功";
                                    Image_save_Num++;
                                }
                                camera_image_gra1.Clear(Color.WhiteSmoke);
                                pictureBoxShow1.Visible = false;
                                picturebox_who_flag = 1;
                            }));
                        }
                    }
                }
                else      //使用第1个picturebox
                {
                    if (three_point_track_dist_flag == 0)   //左边界
                    {
                        camera_image_gra1.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0)), data * pictureBoxShow1.Width / width, image_row_count, pictureBoxShow1.Width / width, pictureBoxShow1.Height / height);
                        if (picturegrid_flag == 0)
                        {
                            camera_image_gra1.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), data * pictureBoxShow1.Width / width, image_row_count, pictureBoxShow1.Width / width, pictureBoxShow1.Height / height);
                        }
                        three_point_track_dist_flag = 1;
                    }
                    else if (three_point_track_dist_flag == 1)    //中线
                    {
                        camera_image_gra1.DrawRectangle(new Pen(Color.FromArgb(0, 0, 255)), data * pictureBoxShow1.Width / width, image_row_count, pictureBoxShow1.Width / width, pictureBoxShow1.Height / height);
                        if (picturegrid_flag == 0)
                        {
                            camera_image_gra1.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 255)), data * pictureBoxShow1.Width / width, image_row_count, pictureBoxShow1.Width / width, pictureBoxShow1.Height / height);
                        }
                        three_point_track_dist_flag = 2;
                    }
                    else    //右边界
                    {
                        camera_image_gra1.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0)), data * pictureBoxShow1.Width / width, image_row_count, pictureBoxShow1.Width / width, pictureBoxShow1.Height / height);
                        if (picturegrid_flag == 0)
                        {
                            camera_image_gra1.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), data * pictureBoxShow1.Width / width, image_row_count, pictureBoxShow1.Width / width, pictureBoxShow1.Height / height);
                        }
                        three_point_track_dist_flag = 0;
                        image_row_count += pictureBoxShow1.Height / height;
                        if (image_row_count >= pictureBoxShow1.Height)
                        {
                            image_row_count = 0;
                            image_get_flag = 0;
                            for (int i = 0; i < pictureBoxShow1.Width; i += pictureBoxShow1.Width / width)
                            {
                                camera_image_gra1.DrawRectangle(new Pen(Color.FromArgb(0, 0, 0)), i, effective_line * pictureBoxShow.Height / height, pictureBoxShow1.Width / width, pictureBoxShow1.Height / height);
                                if (picturegrid_flag == 0)
                                {
                                    camera_image_gra1.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0)), i, effective_line * pictureBoxShow.Height / height, pictureBoxShow1.Width / width, pictureBoxShow1.Height / height);
                                }
                            }
                            effective_line = -5;
                            this.Invoke((EventHandler)(delegate
                            {
                                pictureBoxShow1.Visible = true;
                                pictureBoxShow1.Refresh();
                                if (checkBoxAutoSaveImage.Checked)
                                {
                                    string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                                    pictureBoxShow1.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                                    toolStripStatusLabel2.Text = Image_save_name + "保存成功";
                                    Image_save_Num++;
                                }
                                camera_image_gra.Clear(Color.WhiteSmoke);
                                pictureBoxShow.Visible = false;
                                picturebox_who_flag = 0;
                            }));
                        }
                    }
                }
            }
        }
        
        public void GrayImage_Deal(byte data)    //处理灰度图像
        {
            camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(data, data, data)), image_column_count, image_row_count, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
            if (picturegrid_flag == 0)
            {
                camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(data, data, data)), image_column_count, image_row_count, pictureBoxShow.Width / width, pictureBoxShow.Height / height);
            }
            image_column_count += pictureBoxShow.Width / width;
            if (image_column_count >= pictureBoxShow.Width)
            {
                image_column_count = 0;
                image_row_count += pictureBoxShow.Height / height;
            }
            if (image_row_count >= pictureBoxShow.Height)
            {
                image_row_count = 0;
                image_get_flag = 0;
                this.Invoke((EventHandler)(delegate
                {
                    pictureBoxShow.Refresh();
                    if (checkBoxAutoSaveImage.Checked)
                    {
                        string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                        pictureBoxShow.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                        toolStripStatusLabel2.Text = Image_save_name + "保存成功";
                        Image_save_Num++;
                    }
                }));
            }
        }
 /*------------------------------------------以上是图像处理部分------------------------------------------------------*/

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
            Com_Using.Write(sendstr);
            if(checkBoxSendEndEnter.Checked)
            {
                Com_Using.Write("\r\n");
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
            if (toolTipPicColumnRow.GetToolTip(pictureBoxShow)!=(((int)(Pixel_x + 1)).ToString() + "," + ((int)(Pixel_y + 1)).ToString()))
            {
                toolTipPicColumnRow.SetToolTip(pictureBoxShow, ((int)(Pixel_x + 1)).ToString() + "," + ((int)(Pixel_y + 1)).ToString());
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
            if(Image_save_path!="")
            {
                //pictureBoxShow.Image.Save("C:\\Users\\Zhu wei\\Desktop\\1.bmp",System.Drawing.Imaging.ImageFormat.Bmp);
                if (pictureBoxShow.Image != null)
                {
                    string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                    pictureBoxShow.Image.Save(Image_save_path + "\\"+Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                    toolStripStatusLabel2.Text = Image_save_name+"保存成功";
                    Image_save_Num++;
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
            image_get_flag = 0;
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
            textBoxReceivingArea.Text = "1.去掉了专门的信息显示框，相关信息显示在状态栏上\r\n\r\n2.增加关闭程序时的提示框\r\n\r\n3.新增加三点赛道功能\r\n\r\n4.增加界面换肤功能\r\n\r\n5.日志记录界面换肤操作\r\n\r\n6.日志记录图像宽度和高度\r\n\r\n7.新增图像栅格显示功能";         
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
            Write_Log_FormMain_BackColor(Color.Gold.ToArgb().ToString()+"         ");
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            Write_Log_FormMain_BackColor(Color.Red.ToArgb().ToString() + "         ");
        }

        private void oringeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            Write_Log_FormMain_BackColor(Color.Orange.ToArgb().ToString() + "         ");
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            Write_Log_FormMain_BackColor(Color.Yellow.ToArgb().ToString() + "         ");
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor =Color.FromArgb(0,192,0);
            Write_Log_FormMain_BackColor(Color.FromArgb(0, 192, 0).ToArgb().ToString() + "         ");
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            Write_Log_FormMain_BackColor(Color.Gray.ToArgb().ToString() + "         ");
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            Write_Log_FormMain_BackColor(Color.Blue.ToArgb().ToString() + "          ");
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
            Write_Log_FormMain_BackColor(Color.LightPink.ToArgb().ToString() + "         ");
        }

        private void whitesmokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            Write_Log_FormMain_BackColor(Color.WhiteSmoke.ToArgb().ToString() + "         ");
        }

        public void Write_Log_FormMain_BackColor(string str)
        {
            string path = Application.StartupPath + "\\SystemLog\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path += "FormMain_BackColor.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(str);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }

        private void textBoxPictureWidth_TextChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\SystemLog\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path += "Image_Width.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(textBoxPictureWidth.Text+"   ");
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }

        private void textBoxPictureHeight_TextChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\SystemLog\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path += "Image_Height.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(textBoxPictureHeight.Text + "   ");
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }

        private void picturegridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(picturegrid_flag==0)
            {
                picturegrid_flag = 1;
            }
            else
            {
                picturegrid_flag = 0;
            } 
        }

        private void checkBoxIsWave_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxIsWave.Checked)
            {
                fr_wave.Show();
            }
        }
    }
}
