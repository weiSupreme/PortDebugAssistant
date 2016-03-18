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
        /*----------------------------以上是字段声明------------------------------*/


        /*----------------------------以下是方法------------------------------*/
        private Serialport() { }     //私有构造函数

        /*----------------------------以上是方法------------------------------*/
    }
}
