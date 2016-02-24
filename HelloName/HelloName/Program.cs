using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");//write will keep cursor on current line, writeline will move the cursor to the next line
            string name;

            name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.ReadLine(); //prevents program from immediately closing, will only close when user hits enter
        }
    }
}
