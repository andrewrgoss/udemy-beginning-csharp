using System; //all of the base data types (numbers, text, dates), error handling classes, and console interaction
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespaces tell C# where to find classes we want to use in our program
//BCL = Base Class Library
//System namespace in the BCL contains the console class
//Think of namespace like a file path
//There are thousands of classes within .NET framework


namespace HelloWorld.ui //by default the namespace is named after the project and folder path the class is in.
{ //<-- code block start
    class Program //class definition. Custom type that programmers create. Classes used to represent ideas in code like customers, bank accounts, etc.
    {
        static void Main(string[] args)
        {//<--main() method code start. Methods are the 'verbs' of programming. They are groups of related statements to be performed that accomplish a task that we want the computer to do. Methods are useful for meaningful groupings and code reuse. Main() is a special method. In a console application it is where the program begins.
            Console.WriteLine("Hello world!"); //statement1
            Console.ReadLine(); //statement2
        }//<--main() method code finish
    }
}//<-- code block finish
