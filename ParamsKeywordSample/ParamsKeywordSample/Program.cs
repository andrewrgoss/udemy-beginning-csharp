using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeywordSample
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSum(2, 2, 2);
            PrintSum(1, 2, 3, 4, 5, 6, 7);
            PrintSum();

            Console.ReadLine();
        }

        static void PrintSum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
