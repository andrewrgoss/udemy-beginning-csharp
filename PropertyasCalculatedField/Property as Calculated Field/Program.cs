using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_as_Calculated_Field
{
    //class Rectangle
    //{
    //    public int Width { get; set; }
    //    public int Height { get; set; }

    //    public int Area
    //    {
    //        get
    //        {
    //            return Width * Height;
    //        }
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle aRectangleObject = new Rectangle();

            //set properties
            aRectangleObject.Height = 10;
            aRectangleObject.Width = 5;

            //calls the get accessor, returns 50
            Console.WriteLine("Area = {0}", aRectangleObject.Area);
            Console.ReadLine();

            //error, no set accessor found, we can't assign area
            //aRectangleObject.Area = 20;
        }
    }
}
