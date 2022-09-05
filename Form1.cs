using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;
using Image = System.Drawing.Image;

namespace KeyApp
{
    public partial class Form1 : Form
    {
        public int NumberOfContacts { get; set; }
        public Form1()
        {
            InitializeComponent();

        }


        public Button myText;
        











        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "goooood morning campers!")
            {
                textBox1.Text = "good morning! let's start off with the basics.";
                // new Form2().Show();

            }
            if (textBox1.Text == "good morning! let's start off with the basics.")
            {
                button1.Text = " ";

                button3.Visible = true;
                button3.BackgroundImage = Image.FromFile("C:\\Users\\Emerald\\AppData\\Local\\Discord\\app-1.0.9006\\app.ico");
                button3.ImageAlign = ContentAlignment.MiddleCenter;
                button3.BackgroundImageLayout = ImageLayout.Stretch;
                button3.Text = " ";
                button3.Size = new Size(146, 146);
                tableLayoutPanel2.SetColumnSpan(button3, 1);
                tableLayoutPanel2.SetRowSpan(button3, 3);
                button3.Anchor = (AnchorStyles.Top | AnchorStyles.Left);


                button5.Visible = true;
                button5.BackgroundImage = Image.FromFile("C:\\Users\\Emerald\\Desktop\\Grab-Bag\\78032799_350.png");
                button5.ImageAlign = ContentAlignment.MiddleCenter;
                button5.BackgroundImageLayout = ImageLayout.Stretch;
                button5.Text = " ";
                button5.Size = new Size(146, 146);

                tableLayoutPanel2.SetColumnSpan(button5, 1);
                tableLayoutPanel2.SetRowSpan(button5, 3);
                button5.Anchor = (AnchorStyles.Top | AnchorStyles.Right);



                tableLayoutPanel2.ColumnStyles[1].Width = 10;

            }

            if (button1.Text == "👍")
            {

                textBox1.Text = "great! would you like to do your stretches now or in half an hour?";

                button1.Visible = false;

                button5.Visible = false;

                button3.Visible = true;
                button3.BackgroundImage = null;
                button3.Text = "yeah okay, let's go";
                button3.AutoSize = true;
                tableLayoutPanel2.SetColumnSpan(button3, 3);
                tableLayoutPanel2.SetRowSpan(button3, 1);
                button3.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom);

                button2.Visible = true;
                button2.Text = "ughhh not right now";
                tableLayoutPanel2.SetColumnSpan(button2, 3);
                tableLayoutPanel2.SetRowSpan(button2, 1);

                tableLayoutPanel2.RowStyles[1].Height = 10;
            }



        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "good morning! let's start off with the basics." | textBox1.Text == "amazing! a button was pushed!")
            {
                textBox1.Text = "you're sure clicking that button~!";

                Process.Start("C:\\Users\\Emerald\\AppData\\Local\\Discord\\app-1.0.9006\\Discord");
            }

            if (textBox1.Text == "you're sure clicking that button~!" | textBox1.Text == "amazing! a button was pushed!")
            {
                button1.Visible = true;
                button1.Text = "👍";
                button1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                textBox1.Text = "NEXT";
            }

            if (textBox1.Text == "great! would you like to do your stretches now or in half an hour?")
            {
                textBox1.Text = "NEXT";

                new Form2().Show();

            }




        }






        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "good morning! let's start off with the basics." | textBox1.Text == "you're sure clicking that button~!")
            {
                textBox1.Text = "amazing! a button was pushed!";
                Process.Start("C:\\Users\\Emerald\\AppData\\Local\\Vivaldi\\Application\\vivaldi");
            }

            if (textBox1.Text == "you're sure clicking that button~!" | textBox1.Text == "amazing! a button was pushed!")
            {
                button1.Visible = true;
                button1.Text = "👍";
                button1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                textBox1.Text = "great! would you like to do your stretches now or in half an hour?";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        
    }
}
