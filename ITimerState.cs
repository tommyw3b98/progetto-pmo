namespace tomato
{
    //Interfaccia di metodi usati dal timer
    //Hanno un effetto diverso a seconda dello stato corrente (FOCUS / RELAX)
    public interface ITimerState
    {
        public void Update() { }
        public void Reset() { }
        public void Ready() { }
        public void Ring() { }
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
        public int GetStartingSeconds()
        {
            int seconds = 0;
            return seconds;
        }
    }
}
