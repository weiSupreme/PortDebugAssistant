using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortDebug
{
    public class MyImage
    {
        /*----------------------------以下是变量声明------------------------------*/
        public static int height = 40, width = 140;    //图像高度和宽度
        public static int image_byte_length = 0;
        public static uint image_get_flag = 0;      //采集图像数据标志位
        public static string Image_save_path;            //保存图片路径字符串
        public static UInt32 Image_save_Num = 1;          //保存图片时的名字变量
        public static Graphics camera_image_gra;
        public static Graphics camera_image_gra1;
        private static int image_row_count = 0;
        private static int image_column_count = 0;
        private static int three_point_track_dist_flag = 0;    //三点赛道模式标志位
        private static int picturebox_who_flag = 0;
        private static int effective_line = -5;        //三点赛道模式下的有效行
        public static int picturegrid_flag = 0;
        private static Form1 fr1 = new Form1();
        /*----------------------------以上是变量声明------------------------------*/

        private MyImage()    //私有构造函数
        {
        }

        /*----------------------------以下是方法------------------------------*/

        /*------------------------------------------以下是图像处理部分------------------------------------------------------*/
        public static void GetImageFramehead_Deal(byte data)   //获取图像帧头
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

        public static void TwoPixelImage_Deal(byte data)   //处理鹰眼二值化压缩图像
        {
            byte pixel = new byte();
            byte[] colour = { 255, 0 };
            for (int i = 7; i >= 0; i--)
            {
                pixel = colour[(data >> i) & 0x01];
                camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(pixel, pixel, pixel)), image_column_count, image_row_count, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
                if (picturegrid_flag == 0)
                {
                    camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(pixel, pixel, pixel)), image_column_count, image_row_count, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
                }
                image_column_count += fr1.pictureBoxShow.Width / width;
                if (image_column_count >= fr1.pictureBoxShow.Width)
                {
                    image_column_count = 0;
                    image_row_count += fr1.pictureBoxShow.Height / height;
                }
            }
            if (image_row_count >= fr1.pictureBoxShow.Height)
            {
                image_row_count = 0;
                image_get_flag = 0;
                fr1.Invoke((EventHandler)(delegate
                {
                    fr1.pictureBoxShow.Refresh();
                    if (fr1.checkBoxAutoSaveImage.Checked)
                    {
                        string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                        fr1.pictureBoxShow.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                        fr1.toolStripStatusLabel2.Text = Image_save_name + "保存成功";
                        Image_save_Num++;
                    }
                }));
            }
        }

        private static int threepointtrack_hang = 1;
        public static void ThreePointTrack_Deal(byte data)     //三点赛道模式
        {
            if (effective_line < 0)
            {
                effective_line = data;
                image_row_count = effective_line * fr1.pictureBoxShow.Height / height + fr1.pictureBoxShow.Height / height;
            }
            else
            {
                if (threepointtrack_hang > ((effective_line + 1) * 3))
                {
                    if (picturebox_who_flag == 0)    //使用第0个picturebox
                    {
                        if (three_point_track_dist_flag == 0)   //左边界
                        {
                            camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0)), data * fr1.pictureBoxShow.Width / width, image_row_count, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
                            if (picturegrid_flag == 0)
                            {
                                camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), data * fr1.pictureBoxShow.Width / width, image_row_count, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
                            }
                            three_point_track_dist_flag = 1;
                        }
                        else if (three_point_track_dist_flag == 1)    //中线
                        {
                            camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(0, 0, 255)), data * fr1.pictureBoxShow.Width / width, image_row_count, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
                            if (picturegrid_flag == 0)
                            {
                                camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 255)), data * fr1.pictureBoxShow.Width / width, image_row_count, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
                            }
                            three_point_track_dist_flag = 2;
                        }
                        else    //右边界
                        {
                            camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0)), data * fr1.pictureBoxShow.Width / width, image_row_count, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
                            if (picturegrid_flag == 0)
                            {
                                camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), data * fr1.pictureBoxShow.Width / width, image_row_count, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
                            }
                            three_point_track_dist_flag = 0;
                            image_row_count += fr1.pictureBoxShow.Height / height;
                            if (image_row_count >= fr1.pictureBoxShow.Height)
                            {
                                image_row_count = 0;
                                image_get_flag = 0;
                                threepointtrack_hang = 0;
                                for (int i = 0; i < fr1.pictureBoxShow.Width; i += fr1.pictureBoxShow.Width / width)
                                {
                                    camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(0, 0, 0)), i, effective_line * fr1.pictureBoxShow.Height / height, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
                                    if (picturegrid_flag == 0)
                                    {
                                        camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0)), i, effective_line * fr1.pictureBoxShow.Height / height, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
                                    }
                                }
                                effective_line = -5;
                                fr1.Invoke((EventHandler)(delegate
                                {
                                    fr1.pictureBoxShow.Visible = true;
                                    fr1.pictureBoxShow.Refresh();
                                    if (fr1.checkBoxAutoSaveImage.Checked)
                                    {
                                        string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                                        fr1.pictureBoxShow.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                                        fr1.toolStripStatusLabel2.Text = Image_save_name + "保存成功";
                                        Image_save_Num++;
                                    }
                                    camera_image_gra1.Clear(Color.WhiteSmoke);
                                    fr1.pictureBoxShow1.Visible = false;
                                    picturebox_who_flag = 1;
                                }));
                            }
                        }
                    }
                    else      //使用第1个picturebox
                    {
                        if (three_point_track_dist_flag == 0)   //左边界
                        {
                            camera_image_gra1.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0)), data * fr1.pictureBoxShow1.Width / width, image_row_count, fr1.pictureBoxShow1.Width / width, fr1.pictureBoxShow1.Height / height);
                            if (picturegrid_flag == 0)
                            {
                                camera_image_gra1.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), data * fr1.pictureBoxShow1.Width / width, image_row_count, fr1.pictureBoxShow1.Width / width, fr1.pictureBoxShow1.Height / height);
                            }
                            three_point_track_dist_flag = 1;
                        }
                        else if (three_point_track_dist_flag == 1)    //中线
                        {
                            camera_image_gra1.DrawRectangle(new Pen(Color.FromArgb(0, 0, 255)), data * fr1.pictureBoxShow1.Width / width, image_row_count, fr1.pictureBoxShow1.Width / width, fr1.pictureBoxShow1.Height / height);
                            if (picturegrid_flag == 0)
                            {
                                camera_image_gra1.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 255)), data * fr1.pictureBoxShow1.Width / width, image_row_count, fr1.pictureBoxShow1.Width / width, fr1.pictureBoxShow1.Height / height);
                            }
                            three_point_track_dist_flag = 2;
                        }
                        else    //右边界
                        {
                            camera_image_gra1.DrawRectangle(new Pen(Color.FromArgb(255, 0, 0)), data * fr1.pictureBoxShow1.Width / width, image_row_count, fr1.pictureBoxShow1.Width / width, fr1.pictureBoxShow1.Height / height);
                            if (picturegrid_flag == 0)
                            {
                                camera_image_gra1.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), data * fr1.pictureBoxShow1.Width / width, image_row_count, fr1.pictureBoxShow1.Width / width, fr1.pictureBoxShow1.Height / height);
                            }
                            three_point_track_dist_flag = 0;
                            image_row_count += fr1.pictureBoxShow1.Height / height;
                            if (image_row_count >= fr1.pictureBoxShow1.Height)
                            {
                                image_row_count = 0;
                                image_get_flag = 0;
                                threepointtrack_hang = 0;
                                for (int i = 0; i < fr1.pictureBoxShow1.Width; i += fr1.pictureBoxShow1.Width / width)
                                {
                                    camera_image_gra1.DrawRectangle(new Pen(Color.FromArgb(0, 0, 0)), i, effective_line * fr1.pictureBoxShow.Height / height, fr1.pictureBoxShow1.Width / width, fr1.pictureBoxShow1.Height / height);
                                    if (picturegrid_flag == 0)
                                    {
                                        camera_image_gra1.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0)), i, effective_line * fr1.pictureBoxShow.Height / height, fr1.pictureBoxShow1.Width / width, fr1.pictureBoxShow1.Height / height);
                                    }
                                }
                                effective_line = -5;
                                fr1.Invoke((EventHandler)(delegate
                                {
                                    fr1.pictureBoxShow1.Visible = true;
                                    fr1.pictureBoxShow1.Refresh();
                                    if (fr1.checkBoxAutoSaveImage.Checked)
                                    {
                                        string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                                        fr1.pictureBoxShow1.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                                        fr1.toolStripStatusLabel2.Text = Image_save_name + "保存成功";
                                        Image_save_Num++;
                                    }
                                    camera_image_gra.Clear(Color.WhiteSmoke);
                                    fr1.pictureBoxShow.Visible = false;
                                    picturebox_who_flag = 0;
                                }));
                            }
                        }
                    }
                }
                threepointtrack_hang++;
            }
        }

        public static void GrayImage_Deal(byte data)    //处理灰度图像
        {
            camera_image_gra.DrawRectangle(new Pen(Color.FromArgb(data, data, data)), image_column_count, image_row_count, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
            if (picturegrid_flag == 0)
            {
                camera_image_gra.FillRectangle(new SolidBrush(Color.FromArgb(data, data, data)), image_column_count, image_row_count, fr1.pictureBoxShow.Width / width, fr1.pictureBoxShow.Height / height);
            }
            image_column_count += fr1.pictureBoxShow.Width / width;
            if (image_column_count >= fr1.pictureBoxShow.Width)
            {
                image_column_count = 0;
                image_row_count += fr1.pictureBoxShow.Height / height;
            }
            if (image_row_count >= fr1.pictureBoxShow.Height)
            {
                image_row_count = 0;
                image_get_flag = 0;
                fr1.Invoke((EventHandler)(delegate
                {
                    fr1.pictureBoxShow.Refresh();
                    if (fr1.checkBoxAutoSaveImage.Checked)
                    {
                        string Image_save_name = Convert.ToString(Image_save_Num) + ".bmp";
                        fr1.pictureBoxShow.Image.Save(Image_save_path + "\\" + Image_save_name, System.Drawing.Imaging.ImageFormat.Bmp);
                        fr1.toolStripStatusLabel2.Text = Image_save_name + "保存成功";
                        Image_save_Num++;
                    }
                }));
            }
        }
        /*------------------------------------------以上是图像处理部分------------------------------------------------------*/

        /*----------------------------以上是方法------------------------------*/
    }
}
