using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;

namespace SerialPortDebug
{
    public partial class FormSafety : Form
    {
        private SerialPortDebug.MyFile my_file = new MyFile();

        public FormSafety()
        {
            InitializeComponent();
        }

        private void FormSafety_Load(object sender, EventArgs e)
        {
            String CPU_serialnumber = "";
            CPU_serialnumber = GetCPUSerialNumber() ;
            if (CPU_serialnumber!="")
            {
                textBoxMachineCodes.Text = CPU_serialnumber;
            }
            else
            {
                MessageBox.Show("未获取到机器码，请重启软件");
            }
        }

        /// 获取cpu序列号
        /// </summary>
        /// <returns></returns>
        public static string GetCPUSerialNumber()
        {
            string cpuSerialNumber = string.Empty;
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                cpuSerialNumber = mo["ProcessorId"].ToString();
                break;
            }
            mc.Dispose();
            moc.Dispose();
            return cpuSerialNumber;
        }

        /// 获取硬盘序列号
        /// </summary>
        /// <returns></returns>
        public static string GetDiskSerialNumber()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher();
            mos.Query = new SelectQuery("Win32_DiskDrive", "", new string[] { "PNPDeviceID", "Signature" });
            ManagementObjectCollection myCollection = mos.Get();
            ManagementObjectCollection.ManagementObjectEnumerator em = myCollection.GetEnumerator();
            em.MoveNext();
            ManagementBaseObject moo = em.Current;
            String id = "123";
            id = moo.Properties["signature"].Value.ToString().Trim();
            return id;
        }

        /// 获取网卡硬件地址
        /// </summary>
        /// <returns></returns>
        public static string GetMoAddress()
        {
            string MoAddress = "" ;
            using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                ManagementObjectCollection moc2 = mc.GetInstances();
                foreach (ManagementObject mo in moc2)
                {
                    //if ((bool)mo["IPEnabled"] == true)
                    MoAddress = mo["MacAddress"].ToString();
                    mo.Dispose();
                }
            }
            return MoAddress.ToString();
        }

        public string Set_Password(string machinecode)
        {
            //string pswd = "";
            /*foreach(char ch in machinecode)    //简单模式
            {
                pswd += ch.ToString();
            }*/

            string machinecode_ch = machinecode;  //BFEBFBFF00040651
            char[] pswd_ch = new char[16];
            //加密
            pswd_ch[0] = machinecode_ch[12];
            pswd_ch[1] = machinecode_ch[8];
            pswd_ch[2] = machinecode_ch[1];
            pswd_ch[3] = machinecode_ch[5];
            pswd_ch[4] = machinecode_ch[9];
            pswd_ch[5] = machinecode_ch[15];
            pswd_ch[6] = machinecode_ch[14];
            pswd_ch[7] = machinecode_ch[2];
            pswd_ch[8] = machinecode_ch[3];
            pswd_ch[9] = machinecode_ch[10];
            pswd_ch[10] = machinecode_ch[7];
            pswd_ch[11] = machinecode_ch[13];
            pswd_ch[12] = machinecode_ch[11];
            pswd_ch[13] = machinecode_ch[15];
            pswd_ch[14] = machinecode_ch[4];
            pswd_ch[15] = machinecode_ch[0];
            //以上是加密过程
            string pswd = new string(pswd_ch);
            return pswd;
        }

        public bool Check_IsRegister()
        {
            String pswd = "123", pswd_own = "123";
            pswd_own=Set_Password(GetCPUSerialNumber());
            pswd = my_file.Read_File("RegisterCodes.txt");
            //textBoxMachineCodes.Text = machine_code.Length.ToString();
            //textBoxRegistrationCodes.Text = pswd.Trim().Length.ToString();
            if (String.Equals(pswd_own.Trim(), pswd.Trim()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string pswd = Set_Password(textBoxMachineCodes.Text);
            if (string.Equals(pswd.Trim(), textBoxRegistrationCodes.Text.Trim()))
            {
                MessageBox.Show("注册成功，重启后可以免费使用本软件！！！");
                my_file.Write_String("RegisterCodes.txt", pswd);
                this.Close();
            }
            else
            {
                MessageBox.Show("注册码错误，请重新输入");
            }
        }

        private void buttonRegistrationCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
