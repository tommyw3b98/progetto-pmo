using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace tomato
{
    //Classe che tiene traccia dello stato del timer attivo
    public class Context
    {
        private readonly ITimerState focus;
        private readonly ITimerState relax;
        private  ITimerState customFocus;
        private  ITimerState customRelax;
        private ITimerState currentState;

        private static Context instance;
       
        public bool IsActive { get; set; }
        public int PomodoriLeft { get; set; }
        public int PomodoriCompleted { get; set; }
        public string StatusText { get; set; }

        private Context()
        {
            focus = new FocusTimer(this);
            relax = new RelaxTimer(this);
            IsActive = true;
            PomodoriLeft = 1;
            PomodoriCompleted = 0;
            currentState = focus;
        }

        public void CustomStart(int t1, int t2, int t3)
        {
            customFocus = new CustomFocusTimer(this, t1);
            customRelax = new CustomRelaxTimer(this, t2, t3);
            currentState = customFocus;
        }

        public void DefaultStart()
        {
            currentState = focus;
        }

        public static Context GetInstance()
        {
            if (instance == null)
                instance = new Context();
            return instance;
        }

        public void SetNewState(ITimerState s)
        {
            currentState = s;
        }

        public void Update()
        {
            currentState.Update();
        }

        public void Reset()
        {
            currentState.Reset();
            PomodoriCompleted = 0;
        }

        public string GetCurrentTime()
        {
           string s = currentState.GetCurrentTime();
           return s; 
        }

        public string GetCurrentState()
        {
            string s = currentState.GetCurrentState();
            return s;
        }

        public void Ready()
        {
            currentState.Ready();
        }

        public void Ring()
        {
            currentState.Ring();
        }

        public ITimerState GetFocusState() { return focus; }
        public ITimerState GetRelaxState() { return relax; }
        public ITimerState GetCustomFocusState() { return customFocus; }
        public ITimerState GetCustomRelaxState() { return customRelax; }
    }

    
}
