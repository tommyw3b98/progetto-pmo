using System;
using System.Data;
using System.IO;

namespace tomato
{
    public class StatsManager
    {
        private readonly Context pomodoro;
        private int pomodoroTime; //durata in secondi di un intervallo di focus (1500 se default)
        private int intervalsNum; //numero di pomodori per la sessione corrente
        private readonly string filePath = AppDomain.CurrentDomain.BaseDirectory + "stats.txt";
        private const string COLUMNS_NAME = "Date|Total focus time";

        public StatsManager(Context p)
        {
            pomodoro = p;
        }

        public void StartSessionRecording()
        {
            pomodoroTime = pomodoro.GetStartingSeconds();
            intervalsNum = pomodoro.PomodoriLeft;
        }

        public void RecordSession()
        {
            double totalFocusMinutes = ((pomodoroTime * intervalsNum) / 60);

            using StreamWriter strw = File.AppendText(filePath);
            strw.WriteLine(DateTime.Now.ToShortDateString() + '|' + totalFocusMinutes);
        }

        public DataTable DataTableFromTextFile()
        {
            DataTable result;

            string[] LineArray = File.ReadAllLines(filePath);

            result = FormDataTable(LineArray);

            return result;
        }

        private DataTable FormDataTable(string[] LineArray)
        {
            DataTable dt = new DataTable();

            AddColumnToTable(LineArray, ref dt);

            AddRowToTable(LineArray, ref dt);

            return dt;
        }

        private void AddRowToTable(string[] valueCollection, ref DataTable dt)
        {

            for (int i = 1; i < valueCollection.Length; i++)
            {
                string[] values = valueCollection[i].Split('|');
                DataRow dr = dt.NewRow();
                for (int j = 0; j < values.Length; j++)
                {
                    dr[j] = values[j];
                }
                dt.Rows.Add(dr);
            }
        }

        private void AddColumnToTable(string[] columnCollection, ref DataTable dt)
        {
            string[] columns = columnCollection[0].Split('|');
            foreach (string columnName in columns)
            {
                DataColumn dc = new DataColumn(columnName, typeof(string));
                dt.Columns.Add(dc);
            }
        }

        public void ClearStats()
        {
            File.WriteAllText(filePath, string.Empty);
            using StreamWriter strw = File.AppendText(filePath);
            strw.WriteLine(COLUMNS_NAME);
        }
    }
}
