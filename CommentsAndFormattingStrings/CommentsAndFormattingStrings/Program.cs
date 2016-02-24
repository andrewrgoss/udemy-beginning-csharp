using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentsAndFormattingStrings
{
    class Program
    {
        //we can do a single line comment with two slashes

        /*slash + asterisk does multiple
         * line comments. You must end with an
         * asterisk in a slash to stop */

        /// <summary>
        /// Three slashes before a method or class will do a documentation comment.
        /// We can generate help documentation with this
        /// </summary>
        /// <param name="args"></param> //there are tools that will generate HTML files off of these summary tags

        static void Main(string[] args)
        {
            Console.WriteLine("Let's demo formatting strings. Press enter to begin...");
            Console.ReadLine();
            Console.Clear();

            DemoSubstitutionStrings(); //methods will redirect the program to a different subroutine, run all of that code, and then return to the place it left off
            LeftAlign();
            RightAlign();
            FormatNumericalData();
            StringDotFormat();

        }

        static void DemoSubstitutionStrings() //subroutine example
        {
            Console.WriteLine("Substitution strings are easier to read than concatenation");
            Console.WriteLine("-----------------------------------------------------------");

            //Get some data
            Console.Write("What is your name: ");
            string userName = Console.ReadLine();

            Console.Write("What is your favorite color: ");
            string favoriteColor = Console.ReadLine();

            //substitution strings are in curly braces, they always start with 0 (and then increment). Computers always start from zero.
            //each substitution string is replaced by the value following the string
            // \n used for new line
            Console.WriteLine("Hello {0}! Your favorite color is {1}. \nI am a big fan of the name {0}.\n", userName, favoriteColor);
            
            //we can pass literals or variables
            Console.WriteLine("My favorite number is {0}.", 19);

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        static void LeftAlign()
        {
            Console.WriteLine("Put a comma and a negative number to left align. ex: {0,-15}");
            Console.WriteLine("------------------------------------------------------------");

            string lineOutputFormat = "{0,-15} {1,-2} {2,-5}";
            Console.WriteLine(lineOutputFormat, "John Doe", "OH", "44113");
            Console.WriteLine(lineOutputFormat, "Jane Doe", "NY", "12065");
            Console.WriteLine(lineOutputFormat, "Cheech Marin", "CA", "90210");

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        static void RightAlign()
        {
            Console.WriteLine("Put a comma and a positive number to right align. ex: {1,9}");
            Console.WriteLine("-----------------------------------------------------------");

            /* Two things:
             * 1. We can store a format in a string for later
             * 2. We can use the : and a format code to do things like currency format
            */

            string lineOutputFormat = "{0,-15} {1,9:C}"; //C = format code for currency (will use currency specified on computer, so USD)
            Console.WriteLine(lineOutputFormat, "A12345678", 5302.32);
            Console.WriteLine(lineOutputFormat, "A392848293", 27.32);

            //this one will overflow, watch what happens
            Console.WriteLine(lineOutputFormat, "A20859329", 1232706.00);

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        /* here are some standard number formats
         * 
         * a list of standard codes is found here:
         * http://msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110).aspx
        */

        static void FormatNumericalData()
        {
            Console.WriteLine("The value 12345 in various formats:\n");
            Console.WriteLine("c format: {0:c}", 12345); //c = currency format ($12345.00)
            Console.WriteLine("d9 format: {0:d9}", 12345); //d9 = length of 9, pads 4 numbers on the left to make it 9 (000012345)
            Console.WriteLine("f3 format: {0:f3}", 12345); //f3 = fixed number of decimal places, adds 3 decimal places after: (12345.000)
            Console.WriteLine("n format: {0:n}", 12345); //n = number format (12,345.00)

            Console.WriteLine("\n");

            //notice that upper- or lowercasing for hex determines if letters are upper- or lowercase, determines casing for character that is printed out in the console
            Console.WriteLine("E format: {0:E}", 12345); //exponential format (scientific calculator output)
            Console.WriteLine("e format: {0:e}", 12345); //= 1234500e+004

            Console.WriteLine("For hex we will use 99999 to get some letters.");
            Console.WriteLine("X format: {0:X}", 99999); //hexadecimal format
            Console.WriteLine("x format: {0:x}", 99999);//= 1869f

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        static void StringDotFormat()
        {
            //string.format() allows for substitution strings as well.
            //it returns a string we can store for later

            string totalLine = string.Format("Total: {0:c}", 25.39); //Handles substitution strings. Actually runs a string, stores it in the totalLine variable, and then prints it out to the console.
            Console.WriteLine(totalLine);

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
