using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
namespace tomato
{
    //Stato del timer: FOCUS
    public class FocusTimer : IPomodoroState
    {
        readonly PomodoroContext pomodoro;
        private int secondsLeft;
        private const int FOCUS_TIME = 10;

        public FocusTimer(PomodoroContext p)
        {
            this.pomodoro = p;
            this.secondsLeft = FOCUS_TIME;
        }

        public void Ready()
        {
            this.secondsLeft = FOCUS_TIME;
        }
        
        public void Update()
        {
            if (this.secondsLeft > 0)
            {
                this.secondsLeft--;
            }
            else
            {
                this.pomodoro.PomodoriCompleted++;
                this.pomodoro.PomodoriLeft--;
                if (this.pomodoro.PomodoriLeft > 0)
                {
                    //A ogni cambio di stato suona un campanello
                    //TODO: sistemare in un metodo
                    System.IO.Stream str = Properties.Resources.ding;
                    SoundPlayer snd = new SoundPlayer(str);
                    snd.Play();

                    this.pomodoro.SetNewState(pomodoro.GetRelaxState());
                    this.pomodoro.Ready();
                }
             else this.pomodoro.SetActive(false);
            }
        }

        public void Reset()
        {
            this.secondsLeft = FOCUS_TIME;
            if (pomodoro.GetActive() == false)
                pomodoro.SetActive(true);
        }

        public string GetCurrentTime()
        {
            string currentTime;
            int minutes = secondsLeft / 60;
            int seconds = secondsLeft - (minutes * 60);
            currentTime = minutes.ToString("00") + ":" + seconds.ToString("00");
            return currentTime;
        }

        public string GetCurrentState()
        {
            return "focus";
        }
    }
}
