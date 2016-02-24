using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleDimensionArrayCreation();
            AutoInitializingArrays();
            ArraysAndMethods();
            ArrayClassMethods();
        }
      
        static void SingleDimensionArrayCreation() //initialized by element, one at a time
        {
            Console.WriteLine("Create a single dimension array");
            // Create and fill an array of 3 Integers
            int[] numbers = new int[3];
            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;

            // Now print each value.
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);

            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
        }

        static void AutoInitializingArrays() // initialize an array in the same statement that creates it
        {
            Console.WriteLine("=> Array Initialization.");

            // Array initialization syntax using the new keyword.
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            // Array initialization syntax without using the new keyword.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            // Array initialization with new keyword and size.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);

            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
        }

        static void ArraysAndMethods()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            // Pass array as parameter.
            int[] ages = { 20, 22, 23, 0 };
            PrintArrayElements(ages);

            // Get array as return value.
            int[] numbers = GetNumbersArray();
            PrintArrayElements(numbers);


            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
        }

        static void PrintArrayElements(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, numbers[i]);
        }

        static int[] GetNumbersArray()
        {
            int[] numbers = {1,2,3,4,5 }; //only specify size when array is declared 
            return numbers;
        }

        static void ArrayClassMethods()
        {
            string[] vowels = { "a", "e", "i", "o", "u" };

            // Print
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.Write(vowels[i]);                
            }
            Console.WriteLine();

            Console.Write("Reversed: ");
            Array.Reverse(vowels);

            // Print
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.Write(vowels[i]);
            }
            Console.WriteLine();

            Console.WriteLine("The alphabet has {0} vowels", vowels.Length);

            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
        }
    }
}
