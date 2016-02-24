using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LoggingInterface
{
    static class ILoggerFactory //a factory class is a class whose job is to create new objects of a certain type that satisfy a certain interface
    {
        private static ILogger _myLogger;

        public static ILogger GetLogger()
        {
            if(_myLogger == null)
            {
                string logType = ConfigurationManager.AppSettings["logtype"];

                if(logType == "C")
                {
                    _myLogger = new ConsoleLogger(); //_myLogger is a type of ILogger. ConsoleLogger is being assigned here and this is fine because ConsoleLogger is an ILogger. This satisfies the interface (core concept of polymorphism)
                }
                else if (logType == "F")
                {
                    _myLogger = new FileLogger();
                }
            }

            return _myLogger;
        }
    }
}
