using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace SerialPortDebug
{
    class MyFile
    {
        /*----------------------------以下是字段声明------------------------------*/
        /*----------------------------以上是字段声明------------------------------*/

        /*----------------------------以下是方法------------------------------*/
        public void Save_HeightorWidth(string filename, string text)
        {
            string path = System.Windows.Forms.Application.StartupPath + "\\SystemLog\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path += filename;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(text + "   ");
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }

        public int SetImage_Width()
        {
            string path = System.Windows.Forms.Application.StartupPath + "\\SystemLog\\" + "Image_Width.txt";
            if (File.Exists(path))
            {
                byte[] byData = new Byte[100];
                FileStream file = new FileStream(path, FileMode.Open);
                file.Seek(0, SeekOrigin.Begin);
                file.Read(byData, 0, 100); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,
                //它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
                file.Close();
                int str_width = int.Parse(System.Text.Encoding.ASCII.GetString(byData, 0, byData.Count()));
                if (str_width != 0)
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
            string path = System.Windows.Forms.Application.StartupPath + "\\SystemLog\\" + "Image_Height.txt";
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

        public void Write_Log_FormMain_BackColor(string str)
        {
            string path = System.Windows.Forms.Application.StartupPath + "\\SystemLog\\";
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

        public Color Read_Log_FormMian_BackColor()
        {
            string path = System.Windows.Forms.Application.StartupPath + "\\SystemLog\\" + "FormMain_BackColor.txt";
            if (File.Exists(path))
            {
                byte[] byData = new Byte[100];
                FileStream file = new FileStream(path, FileMode.Open);
                file.Seek(0, SeekOrigin.Begin);
                file.Read(byData, 0, 100); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,
                //它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
                string str_color = System.Text.Encoding.ASCII.GetString(byData, 0, byData.Count());
                file.Close();
                return Color.FromArgb(Convert.ToInt32(str_color));
            }
            else
            {
                return Color.FromArgb(0, 192, 0);
            }
        }
        /*----------------------------以上是方法------------------------------*/
    }
}
