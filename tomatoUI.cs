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
using System.Media;



namespace tomato
{
    public partial class tomatoUI : Form
    {
        
        private PomodoroContext p;
        
        public tomatoUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = PomodoroContext.GetInstance();
            timeLeftText.Text = p.GetCurrentTime();
            complete.Text = "Complete: " + p.PomodoriCompleted;
            left.Text = "Left: " + p.PomodoriLeft;
            currentStatusText.Text = p.GetCurrentState();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();

            //disattiva il box numerico finché il timer non è resettato
            counter.Enabled = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("Sessions left: " + p.PomodoriLeft);
            if (p.GetActive() == true)
            {
                p.Update();
                timeLeftText.Text = p.GetCurrentTime();
                currentStatusText.Text = p.GetCurrentState();
            }
            else
            {
                timer1.Stop();
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Session complete!");                
            }
            complete.Text = "Complete: " + p.PomodoriCompleted;
            left.Text = "Left: " + p.PomodoriLeft;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            counter.Enabled = true;
            timer1.Stop();
            p.Reset();
            p.PomodoriLeft = Decimal.ToInt32(counter.Value);
            p.PomodoriCompleted = 0;
            complete.Text = "Complete: " + p.PomodoriCompleted;
            left.Text = "Left " + p.PomodoriLeft;
            timeLeftText.Text = p.GetCurrentTime();
            currentStatusText.Text = p.GetCurrentState();
        }

        private void PomodoriCounter_ValueChanged(object sender, EventArgs e)
        {
            p.PomodoriLeft = Decimal.ToInt32(counter.Value);
            left.Text = "Left: " + counter.Value.ToString();
            Debug.WriteLine("new value:" + p.PomodoriLeft);
        }
    }
}
