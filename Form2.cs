using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace KeyApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }

        public string GetForm2Data
        {
            get { return textBox1.Text; }
        }

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void Form2_Load(object sender, EventArgs e)
        {


            wplayer.URL = "C:\\Users\\Emerald\\Desktop\\Sound ON\\Nyakuza Manholes.mp3";
            wplayer.controls.play();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            wplayer.controls.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private int duration = 900;




        private void count_down(object sender, EventArgs e)
        {

            if (duration == 0)
            {
                timer1.Stop();

            }
            else if (duration > 0)
            {
                duration--;
                label1.Text = duration.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            wplayer.controls.stop();



        }




    }


}
