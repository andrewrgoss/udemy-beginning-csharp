using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingInterface
{
    class FileLogger : ILogger
    {
        public void WriteToLog(string message)
        {
            var fileWriter = File.AppendText(DateTime.Now.ToString("yyyyMMddHHmmss_") + "log.txt"); //if path is not specified, this will output to directory path where the application is currently running from
            fileWriter.WriteLine(message);
            fileWriter.Close(); //one of the best things about .NET is how easy it is to do common tasks using the framework library
        }
    }
}
