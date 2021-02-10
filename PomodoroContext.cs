using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace tomato
{
    //Classe che tiene traccia dello stato del timer attivo
    public class PomodoroContext
    {
        private readonly IPomodoroState focus;
        private readonly IPomodoroState relax;
        private IPomodoroState currentState;
        private static PomodoroContext instance;
       
        private bool isActive;
        public int PomodoriLeft { get; set; }
        public int PomodoriCompleted { get; set; }
        public string StatusText { get; set; }

        private PomodoroContext()
        {
            focus = new FocusTimer(this);
            relax = new RelaxTimer(this);
            isActive = true;
            PomodoriLeft = 1;
            PomodoriCompleted = 0;
            currentState = focus;
        }

        public static PomodoroContext GetInstance()
        {
            if (instance == null)
                instance = new PomodoroContext();
            return instance;
        }

        public bool GetActive()
        {
            return isActive;
        }

        public void SetActive(bool active)
        {
            this.isActive = active;
        }

        public void SetNewState(IPomodoroState s)
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

        public IPomodoroState GetFocusState() { return focus; }
        public IPomodoroState GetRelaxState() { return relax; }
    }

    
}
