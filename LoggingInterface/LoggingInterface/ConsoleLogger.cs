using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingInterface
{
    class ConsoleLogger : ILogger
    {
        public void WriteToLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
