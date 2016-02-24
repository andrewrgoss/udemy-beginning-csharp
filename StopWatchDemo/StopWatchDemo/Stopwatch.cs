using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchDemo
{
    class Stopwatch
    {
        private DateTime _startTime;

        public void Start()
        {
            _startTime = DateTime.Now;
        }
        public void Stop()
        {
            TimeSpan elapsed = DateTime.Now - _startTime;

            Console.WriteLine("The elapsed time is: {0}s {1}ms", elapsed.Seconds, elapsed.Milliseconds);
        }
    }
}
