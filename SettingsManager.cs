namespace tomato
{
    class SettingsManager
    {
        public int CustomRelaxTime { get; set; }
        public int CustomFocusime { get; set; }
        public int CustomLongRelaxTime { get; set; }

        private readonly Context pomodoro;

        public SettingsManager(Context p)
        {
            this.pomodoro = p;
        }

        public void LoadCustomSettings()
        {
            pomodoro.CustomStart(CustomFocusime, CustomRelaxTime, CustomLongRelaxTime);
        }

        public void LoadDefaultSettings()
        {
            pomodoro.DefaultStart();
        }
    }
}
