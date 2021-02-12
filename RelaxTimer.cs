using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace tomato
{
    //Stato del timer: RELAX
    public class RelaxTimer : ITimerState
    {
        readonly Context pomodoro;
        protected int secondsLeft;
        private const int RELAX_TIME = 300;
        private const int LONG_RELAX_TIME = 900;

        public RelaxTimer(Context p)
        {
            this.pomodoro = p;
            secondsLeft = RELAX_TIME;
        }

        public virtual void Ready()
        {
            //Ogni 4 cicli la pausa è più lunga
            if (pomodoro.PomodoriCompleted % 4 == 0)
                secondsLeft = LONG_RELAX_TIME;
            else
                secondsLeft = RELAX_TIME;
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

                Ring();
                this.pomodoro.SetNewState(pomodoro.GetFocusState());
                this.pomodoro.Ready();
            }
        }

        public virtual void Reset()
        {
            this.pomodoro.SetNewState(pomodoro.GetFocusState());
            if (pomodoro.IsActive == false)
                pomodoro.IsActive = true;
            this.pomodoro.Ready();
        }

        //Restituisce una stringa che indica il tempo rimanente del timer corrente [mm:ss]
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
            return "relax";
        }
    }
}
