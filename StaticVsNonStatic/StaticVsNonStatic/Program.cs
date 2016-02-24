using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsNonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your mph: ");
            double mph = double.Parse(Console.ReadLine());

            //no need to instantiate statics
            double kmh = Conversions.MphToKmh(mph);
            Console.WriteLine("{0} mph = {1} kmh", mph, kmh);

            Console.ReadLine();
        }
    }

    class Conversions
    {
        public static double MphToKmh(double mph)
        {
            return mph * 1.60934;
        }
    }
}
