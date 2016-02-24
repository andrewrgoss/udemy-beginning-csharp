using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingInterface
{
    interface ILogger
    {
        void WriteToLog(string message);
    }
}
