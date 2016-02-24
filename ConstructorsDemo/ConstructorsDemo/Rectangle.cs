using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    class Rectangle
    {
        private int length;
        private int width;
        
        public Rectangle() //empty constructor
        {
            Console.WriteLine("We are in the rectangle's constructor.");
            length = 0;
            width = 0;
        }

        public Rectangle(int sideA, int sideB) //these are parameters being passed into the constructor
        {
            Console.WriteLine("This is the constructor that takes two values.");
            length = sideA;
            width = sideB;
        }

        public int GetArea() //method that calculates the area
        {
            return length * width; 
        }
    }
}
