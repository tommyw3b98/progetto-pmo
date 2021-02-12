using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace tomato
{
    public partial class tomatoUI : Form
    {
        
        private Context p;
        
        public tomatoUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = Context.GetInstance();
            timeLeftText.Text = p.GetCurrentTime();
            complete.Text = "Complete: " + p.PomodoriCompleted;
            left.Text = "Left: " + p.PomodoriLeft;
            currentStatusText.Text = p.GetCurrentState();
        }

        public void UpdateUI()
        {
            complete.Text = "Complete: " + p.PomodoriCompleted;
            left.Text = "Left: " + p.PomodoriLeft;
            timeLeftText.Text = p.GetCurrentTime();
            currentStatusText.Text = p.GetCurrentState();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //disattiva il box numerico finché il timer non è resettato
            counter.Enabled = false;
            //disattiva il tasto delle impostazioni finché il timer non è resettato
            settingsButton.Enabled = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (p.IsActive == true)
            {
                p.Update();
                timeLeftText.Text = p.GetCurrentTime();
                currentStatusText.Text = p.GetCurrentState();
            }
            else
            {
                timer1.Stop();
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Session complete!\nTo start another session click on reset or reboot the app.");
            }
            complete.Text = "Complete: " + p.PomodoriCompleted;
            left.Text = "Left: " + p.PomodoriLeft;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            counter.Enabled = true;
            settingsButton.Enabled = true;

            timer1.Stop();
            p.Reset();
            p.PomodoriLeft = Decimal.ToInt32(counter.Value);
            UpdateUI();
        }

        private void PomodoriCounter_ValueChanged(object sender, EventArgs e)
        {
            p.PomodoriLeft = Decimal.ToInt32(counter.Value);
            left.Text = "Left: " + p.PomodoriLeft;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settingsForm settingsUI = new settingsForm(p, this);
            settingsUI.ShowDialog();
        }
    }
}
