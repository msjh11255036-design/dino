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

namespace dino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Left = 350;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer1.Interval = 200;
            timer2.Interval = 5;
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
            pictureBox2.Image=imageList1.Images[num];
            if (num == 1)
            {
                num = 0;
            }
            else
            {
                num++;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            pictureBox3.Left -= 5;
            if (pictureBox1.Location.X < -1000)
            {
                pictureBox1.Left = 1000;
            }
            if (pictureBox3.Location.X < -1000)
            {
                pictureBox3.Left = 1000;
            }
            label1.Text = pictureBox1.Location.X.ToString();
            label2.Text =pictureBox3.Location.X.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left -= 5;
            if(pictureBox4.Location.X < -1000)
            { 
                pictureBox4.Left = 1000;
            }
        }
        bool isjump=false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                isjump=true;      
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { isjump = true; }
        }
    }
}
