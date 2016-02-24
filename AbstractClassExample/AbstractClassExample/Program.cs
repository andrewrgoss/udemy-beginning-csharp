using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3]; //without inheritance and polymorphism we would have to create an array of each type of shape. A better solution would be to create a base class and put all the derived shapes into an array.
            shapes[0] = new Triangle();
            shapes[1] = new Square();
            shapes[2] = new Circle();

            foreach (var s in shapes)
                s.Draw();

            Console.ReadLine();
        }
    }

    abstract class Shape
    {
        abstract public void Draw();
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing the triangle!");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing the square!");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing the circle!");
        }
    }
}
