using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimerExample
{
    public partial class Form1 : Form
    {
        int counter = 0;

        Stopwatch myWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (countTimer.Enabled == false)
            {
                countTimer.Enabled = true;
                startButton.Text = "Pause";

                //myWatch.Reset();
                myWatch.Start();
            }
            else
            {
                countTimer.Enabled = false;
                startButton.Text = "Start";

                myWatch.Stop();
                timeOutput.Text = myWatch.Elapsed.ToString(@"ss\:ff");
            }
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            // add 1 to counter and display the value to the screen
            counter++;
            counterLabel.Text = $"{counter}";

            // based on the value of the counter a different colour is shown

            //if (counter == 1) 
            //{
            //    colourLabel.BackColor = Color.LightGreen;
            //}
            //else if (counter == 2) 
            //{
            //    colourLabel.BackColor = Color.DodgerBlue;
            //}
            //else
            //{
            //    colourLabel.BackColor = Color.Yellow;
            //    counter = 0; 
            //}

            if (counter % 3 == 1)
            {
                colourLabel.BackColor = Color.LightGreen;
            }
            else if (counter % 3 == 2)
            {
                colourLabel.BackColor = Color.DodgerBlue;
            }
            else
            {
                colourLabel.BackColor = Color.Yellow;
            }
        }
    }
}
