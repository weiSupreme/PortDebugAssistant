using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProduceRegisterCodes_Click(object sender, EventArgs e)
        {
            if(textBoxMachineCodes.Text!="")
            {
                //string pswd = "";
                /*foreach(char ch in machinecode)    //简单模式
                {
                    pswd += ch.ToString();
                }*/

                string machinecode_ch = textBoxMachineCodes.Text;  //BFEBFBFF00040651
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
                textBoxRegistrationCodes.Text = pswd;
            }
            else
            {
                MessageBox.Show("请输入机器码");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
