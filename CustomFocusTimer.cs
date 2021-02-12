using System;
using System.Collections.Generic;
using System.Text;

namespace tomato
{
    public class CustomFocusTimer : FocusTimer
    {
        private readonly Context pomodoro;
        private readonly int focusTime;

        public CustomFocusTimer(Context p, int time) :base(p)
        {
            pomodoro = p;
            focusTime = time * 60;
            secondsLeft = focusTime;
        }

        public override void Ready()
        {
            this.secondsLeft = focusTime;
        }

        public override void Update()
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

                    this.pomodoro.SetNewState(pomodoro.GetCustomRelaxState());
                    this.pomodoro.Ready();
                }
                else this.pomodoro.IsActive = false;
            }
        }
    }
}
