using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Messenger myMessenger = new Messenger();
            myMessenger.SayHello();

            Console.ReadLine();
        }
    }
}
