using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b, int c) //allowed to have same type, same name as long as methods have different parameters. This is called overloading. Overloading allows user to specify as many parameters as needed, default values are provided for others.
        {
            return a + b + c;
        }

        public decimal add(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
