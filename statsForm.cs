using System;
using System.Windows.Forms;

namespace tomato
{
    public partial class StatsForm : Form
    {
        private readonly StatsManager manager;

        public StatsForm(StatsManager m)
        {
            this.manager = m;
            InitializeComponent();
        }

        private void StatsForm_Load(object sender, EventArgs e)
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
