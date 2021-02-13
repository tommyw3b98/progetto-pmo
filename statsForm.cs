using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tomato
{
    public partial class statsForm : Form
    {
        private StatsManager manager;

        public statsForm(StatsManager m)
        {
            this.manager = m;
            InitializeComponent();
        }

        private void statsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = manager.DataTableFromTextFile();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //pulisci tabella
            manager.ClearStats();
            //aggiorna
            dataGridView1.DataSource = manager.DataTableFromTextFile();
        }
    }
}
