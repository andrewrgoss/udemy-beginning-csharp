using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();

            Console.WriteLine("{0}", c.add(1, 2));
            Console.WriteLine("{0}", c.add(1, 2, 3));

            Console.ReadLine();
        }
    }
}
