using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cps_test
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private int timer = 10;
        private bool timerStart = false;
        private bool timerIsNowOn = false;
        private double maxCPS;
        private double clicksPerSecond;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            startTimer();
            count++;
            clickButton.Text = "Clicks: " + count;
            timerIsNowOn = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            if (timerIsNowOn == true)
            {
                timerCounter.Text = "Time: " + timer.ToString();
            }

            if (timer == 0)
            {
                timer1.Stop();
                clicksPerSecond = count / 10.0;
                DialogResult b = MessageBox.Show(clicksPerSecond + " CPS.", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (clicksPerSecond > maxCPS)
                {
                    maxCPS = clicksPerSecond;
                    label1.Text = "Max CPS: " + maxCPS;
                }
                restart();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        { 
           
        }

        public void startTimer()
        {
            if (timerStart == false)
            {
                timerStart = true;
                timer1.Start();
                
            }
        }

        public void restart()
        {
            count = 0;
            timerStart = false;
            clickButton.Text = "Clicks: 0";
            timer = 10;
            timerIsNowOn = false;
            timer1.Stop();
            timerCounter.Text = "Time: 10";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerCounter.Text = "Time: 10";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult d = MessageBox.Show("Are you sure?", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            if (d == DialogResult.Retry)
            {
                restart();
            }
            else
            {
                timer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to quit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to reset?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                maxCPS = 0;
                label1.Text = "Max CPS: 0";
                restart();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("made by ur mom, cps click tester");
        }
    }
}
