using System;
using System.Media;
using System.Windows.Forms;

namespace tomato
{
    public partial class TomatoUI : Form
    {
        private Context p;
        private StatsManager sManager;

        public TomatoUI()
        {
            InitializeComponent();
            this.Icon = tomato.Properties.Resources.Graphicloads_Food_Drink_Tomato;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = Context.GetInstance();
            p.ActiveSession = false;
            sManager = new StatsManager(p);
            UpdateUI();
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
            //se nuova sessione inizia  a registrare le statistiche
            if (p.ActiveSession == false)
            {
                p.ActiveSession = true;
                sManager.StartSessionRecording();
            }

            timer1.Start();
            startButton.Enabled = false;
            startButton.Text = "START";
            stopButton.Enabled = true;

            counter.Enabled = false;
            settingsButton.Enabled = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startButton.Enabled = true;
            startButton.Text = "RESUME";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (p.IsActive)
            {
                p.Update();

                timeLeftText.Text = p.GetCurrentTime();
                currentStatusText.Text = p.GetCurrentState();
            }
            else //Fine sessione
            {
                //scrivi statistiche della sessione su file
                p.ActiveSession = false;
                sManager.RecordSession();

                timer1.Stop();
                startButton.Enabled = false;
                stopButton.Enabled = false;

                SystemSounds.Asterisk.Play();
                MessageBox.Show("Session complete!\nTo start another session click on reset.");
            }
            complete.Text = "Complete: " + p.PomodoriCompleted;
            left.Text = "Left: " + p.PomodoriLeft;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            counter.Enabled = true;
            settingsButton.Enabled = true;
            startButton.Enabled = true;
            stopButton.Enabled = false;
            startButton.Text = "START";

            timer1.Stop();

            p.Reset();
            p.PomodoriLeft = decimal.ToInt32(counter.Value);

            UpdateUI();
        }

        private void PomodoriCounter_ValueChanged(object sender, EventArgs e)
        {
            p.PomodoriLeft = decimal.ToInt32(counter.Value);
            left.Text = "Left: " + p.PomodoriLeft;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsUI = new SettingsForm(p, this);
            settingsUI.ShowDialog();
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            StatsForm stats = new StatsForm(sManager);
            stats.ShowDialog();
        }
    }
}
