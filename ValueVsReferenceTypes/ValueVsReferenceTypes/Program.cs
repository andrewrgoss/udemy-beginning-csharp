using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /********* VALUE TYPES *********/
            int x = 5;

            ChangeValue(x); //only set to 10 in this method, one method completes program will go back to using x value in the main arguments scope. This application will print out x being equal to 5.

            Console.WriteLine("X: {0}", x);

            /********* REFERENCE TYPES *********/

            Point1 p1 = new Point1(); //reference types are usually classes and arrays
            p1.X = 5;
            p1.Y = 10;

            Point1 p2 = p1;
            Point1 p3 = p2;

            p3.Y = 50;

            Console.WriteLine(p2.Y);

            Point2 p10 = new Point2();
            p10.X = 10;
            p10.Y = 5;

            ChangePoint(p10);

            Console.WriteLine("X: {0}, Y:{1}", p10.X, p10.Y);

            Console.ReadLine();
        }

        private static void ChangePoint(Point2 p)
        {
            p.X = 20;
            p.Y = 10;
        }

        private static void ChangeValue(int x)
        {
            x = 10; 
        }
     
        class Point1
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        class Point2
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
