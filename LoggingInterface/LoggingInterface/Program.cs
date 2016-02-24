using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger log = ILoggerFactory.GetLogger(); //creates interface, calls method so it has something to log with

            log.WriteToLog("Hello World!");
            Console.ReadLine();
        }
    }
}
