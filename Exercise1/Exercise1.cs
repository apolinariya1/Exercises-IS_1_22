using System;

namespace Exercise1
{
    class Engine
    {
        private const int stateStopped = 1;
        private const int stateStarted = 2;
        public int engineState;

        public void Start()
        {
            Console.Out.WriteLine("Start");
            engineState = stateStopped;
        }

        public void Stop()
        {
            Console.Out.WriteLine("Stop");
            engineState = stateStarted;
        }

        public string getState()
        {
            return (engineState == stateStopped) ? "STOPPED" : "STARTED";
        }
    }
}