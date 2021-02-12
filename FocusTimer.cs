using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
namespace tomato
{
    //Stato del timer: FOCUS
    public class FocusTimer : ITimerState
    {
        readonly Context pomodoro;
        protected int secondsLeft;
        private const int FOCUS_TIME = 10;

        public FocusTimer(Context p)
        {
            this.pomodoro = p;
            this.secondsLeft = FOCUS_TIME;
        }

        public virtual void Ready()
        {
            this.secondsLeft = FOCUS_TIME;
        }

        protected void Ring()
        {
            System.IO.Stream str = Properties.Resources.ding;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }
        
        public virtual void Update()
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
                    Ring();
                    this.pomodoro.SetNewState(pomodoro.GetRelaxState());
                    this.pomodoro.Ready();
                }
                else this.pomodoro.IsActive = false;
            }
        }

        public void Reset()
        {
            Ready();
            if (pomodoro.IsActive == false)
                pomodoro.IsActive = true;
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
