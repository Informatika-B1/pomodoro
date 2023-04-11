using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro_OOP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Left += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value; 
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
        bool isRunning = false;
        int detik = 25 * 60;
        private void button2_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                button2.Text = "Start";
                isRunning = false;
                timer1.Enabled = false;
                detik = 25 * 60;
                label2.Text = "25 : 00";
            }
            else
            {
                button2.Text = "Pause";
                isRunning = true;
                timer1.Enabled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            detik -= 1;
            if(detik < 1)
            {
                isRunning = false;
                timer1.Enabled = false;
                button2.Text = "Start";
                detik = 25 * 60;
                label4.Text = "25 : 00";
            }

            int sisaMenit = detik / 60;
            int sisaDetik = detik - (sisaMenit * 60);
            
            label4.Text = detik.ToString() + " : " + sisaDetik;
        }
    }
}
