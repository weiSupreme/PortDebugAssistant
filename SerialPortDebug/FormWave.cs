using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortDebug
{
    public partial class FormWave : Form
    {
        /*---------变量定义-----------*/
        private Int32 wave_x = 0, wave_y = 0, wave_x_last = 0, wave_y_last = 0;
        Bitmap wave_bit = new Bitmap(640,480);
        Graphics wave_gra ;

        /*----------------方法--------------------*/
        public FormWave()
        {
            InitializeComponent();
        }

        private void FormWave_Load(object sender, EventArgs e)
        {
            pictureBoxWave.Image = wave_bit;
            wave_gra = Graphics.FromImage(pictureBoxWave.Image);
            wave_x_last = 0;
            wave_y_last = pictureBoxWave.Height - 1;
        }

        public void Draw_Wave(byte y)
        {
            wave_x = wave_x_last+4;
            wave_y = pictureBoxWave.Height - y-1;
            wave_gra.DrawLine(new Pen(Color.Red, 0.5f), new Point(wave_x_last, wave_y_last), new Point(wave_x, wave_y));
            this.Invoke((EventHandler)(delegate
            {
                pictureBoxWave.Refresh();
            }));
            if (wave_x >= pictureBoxWave.Width - 5)
            {
                wave_gra.Clear(Color.Transparent);
                wave_x = 0;
            }
            wave_y_last = wave_y;
            wave_x_last = wave_x;
        }
    }
}
