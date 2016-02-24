using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualandOverrideSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon p = new Rectangle(); //polymorphism example
            p.Draw();

            Console.ReadLine();
        }
    }

    class Polygon
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am drawing a polygon");
        }
    }

    class Rectangle : Polygon //inherits from polygon
    {
        public override void Draw()
        {
            base.Draw(); //calls the base class draw() method
            Console.WriteLine("I am drawing a rectangle");
        }
    }
}
