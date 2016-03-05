using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;

namespace SerialPortDebug
{
    public class Serialport
    {
        /*----------------------------以下是字段声明------------------------------*/
        public static string[] portname_str = SerialPort.GetPortNames();
        public static int[] BaudRates = { 9600, 19200, 38400, 56000, 57600, 115200, 128000, 256000 };
        public static int[] bytesizes = { 5, 6, 7, 8 };
        public static int[] parities = { 0, 1, 2 };
        public static int[] stopbits = { 1, 2 };
        private static Form1 fr1 = new Form1();
        /*----------------------------以上是字段声明------------------------------*/


        /*----------------------------以下是方法------------------------------*/
        private Serialport() { }     //私有构造函数

        public static void Init_Serialport()
        {
            //---------获取串口号--------//
            if (portname_str.Length > 0)
            {
                fr1.comboBoxCom.SelectedText = portname_str[0];
                foreach (string s in portname_str)
                    fr1.comboBoxCom.Items.Add(s);
            }
            //--------选择波特率--------//
            fr1.comboBoxBaudRate.SelectedText = "115200";
            foreach (int baudrate in BaudRates)
                fr1.comboBoxBaudRate.Items.Add(baudrate);
            //--------选择数据位--------//
            fr1.comboBoxByteSize.SelectedText = "8";
            foreach (int bytesize in bytesizes)
                fr1.comboBoxByteSize.Items.Add(bytesize);
            //--------选择校验位-------//
            fr1.comboBoxParity.SelectedText = "0";
            foreach (int parity in parities)
                fr1.comboBoxParity.Items.Add(parity);
            //---------选择停止位---------//
            fr1.comboBoxStopBits.SelectedText = "1";
            foreach (int stopbit in stopbits)
                fr1.comboBoxStopBits.Items.Add(stopbit);
        }

        /*----------------------------以上是方法------------------------------*/
    }
}
