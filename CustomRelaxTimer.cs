using System;
using System.Collections.Generic;
using System.Text;

namespace tomato
{
    public class CustomRelaxTimer : RelaxTimer
    {
        private readonly int relaxTime;
        private readonly int  longRelaxTime;
        private readonly Context  pomodoro;
        
        
        public CustomRelaxTimer(Context p, int time, int longTime) : base(p)
        {
            pomodoro = p;
            relaxTime = time * 60;
            longRelaxTime = longTime * 60;
            secondsLeft = relaxTime;
        }

        public override void Ready()
        {
            //Ogni 4 cicli la pausa è più lunga
            if (pomodoro.PomodoriCompleted % 4 == 0)
                secondsLeft = longRelaxTime;
            else
                secondsLeft = relaxTime;
        }

        public override void Update()
        {
            if (this.secondsLeft > 0)
            {
                this.secondsLeft--;
            }
            else
            {
                Ring();
                this.pomodoro.SetNewState(pomodoro.GetCustomFocusState());
                this.pomodoro.Ready();
            }
        }

        public override void Reset()
        {
            this.pomodoro.SetNewState(pomodoro.GetCustomFocusState());
            if (pomodoro.IsActive == false)
                pomodoro.IsActive = true;
            this.pomodoro.Ready();
        }

    }
}
