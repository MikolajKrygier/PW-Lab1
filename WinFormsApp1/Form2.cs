using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        int timeS, timeM, timeMS;
        bool isactive;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isactive = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isactive = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isactive = false;

            ResetTime();
        }

        private void ResetTime()
        {
            timeS = 0;
            timeM = 0;
            timeMS = 0;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isactive)
            {
                timeMS++;

                if (timeMS >= 100)
                {
                    timeS++;
                    timeMS = 0;

                    if (timeS >= 60)
                    {
                        timeM++;
                        timeS = 0;
                    }
                }
            }
            DrawTime();
        }

        private void DrawTime()
        {
            label2.Text = String.Format("{0:00}", timeS);
            label1.Text = String.Format("{0:00}", timeM);
            label3.Text = String.Format("{0:00}", timeMS);
        }
    }
}
