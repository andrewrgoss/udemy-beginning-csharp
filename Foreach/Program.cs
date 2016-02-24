using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] someLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            int[] someNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var letter in someLetters)
            {
                Console.WriteLine(letter);
            }

            foreach (var num in someNumbers)
            {
                if(num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }

            Console.ReadLine();
        }
    }
}
