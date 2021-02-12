using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tomato
{
    public partial class settingsForm : Form
    {
        private readonly SettingsManager s;
        private readonly tomatoUI mainWindow;

        public settingsForm(Context p, tomatoUI t)
        {
            InitializeComponent();
            s = new SettingsManager(p);
            mainWindow = t;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (this.isCustomCheckBox.Checked)
            {
                s.CustomFocusime = decimal.ToInt32(focusCounter.Value);
                s.CustomRelaxTime = decimal.ToInt32(relaxCounter.Value);
                s.CustomLongRelaxTime = decimal.ToInt32(longRelaxCounter.Value);
                s.LoadCustomSettings();
            }
            else s.LoadDefaultSettings();
            mainWindow.UpdateUI();
            this.Close();
        }

        private void isCustomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isCustomCheckBox.Checked)
            {
                focusCounter.Enabled = true;
                relaxCounter.Enabled = true;
                longRelaxCounter.Enabled = true;
            }
            else if (!isCustomCheckBox.Checked)
            {
                focusCounter.Enabled = false;
                relaxCounter.Enabled = false;
                longRelaxCounter.Enabled = false;
            }
        }
    }
}
