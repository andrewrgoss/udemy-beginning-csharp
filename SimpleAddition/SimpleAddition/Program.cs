using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the first number: ");

            string userInput = Console.ReadLine();

            int number1 = int.Parse(userInput);

            Console.Write("Enter the second number: ");
            userInput = Console.ReadLine();

            int number2 = int.Parse(userInput);

            int sum = number1 + number2;

            Console.WriteLine("The sum is: " + sum); //turn number into string by calling a method called 'tostring.' Console.writeline, because it prints strings out to the console, will automatically call 'tostring' to anything that is passed in

            Console.WriteLine("The sum is: " + sum.ToString()); //"The sum is: " + sum.ToString() = expression example

            Console.WriteLine("The sum is: " + (number1 + number2)); //expression chaining example

            Console.ReadLine();

        }
    }
}
