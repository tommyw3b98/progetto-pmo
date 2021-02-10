using System;
using System.Collections.Generic;
using System.Text;

namespace tomato
{
    //Interfaccia di metodi usati dal timer
    //Hanno un effetto diverso a seconda dello stato corrente (FOCUS / RELAX)
    public interface IPomodoroState
    {
        public void Update() { }
        public void Reset() { }
        public void Ready() { }
        public string GetCurrentState()
        {
            string s = "dummy string";
            return s;
        }
        public string GetCurrentTime() 
        {
            string s = "dummy string";
            return s;
        }
    }
}
