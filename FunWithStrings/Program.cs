using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringsAreImmutable();
            ComparingStrings();
            StringsHaveLengthAndIndexes();
            CasingAndWhiteSpace();
            UsefulCharacterMethods();
            EditingStrings();
            SplitAndJoin();
        }


        static void StringsAreImmutable()
        {
            // immutable is a fancy word that means that whenever you change a string
            // a new string is returned
            string s1 = "Hello";

            // call ToUpper and then print the value of s1
            s1.ToUpper();
            Console.WriteLine("s1: {0}", s1);

            // assign the result of ToUpper to the existing variable
            s1 = s1.ToUpper();
            Console.WriteLine("s1: {0}", s1);

            Console.ReadLine();
            Console.Clear();
        }

        static void ComparingStrings()
        {
            string s1 = "hi";
            string s2 = "HI";

            // using == or != is case sensitive. String comparisons are case sensitive
            if (s1 != s2)
            {
                Console.WriteLine("s1 is not equal to s2");
            }

            // the .Equals() method can take an option to ignore casing
            if (s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("s1 is equal to s2");
            }

            Console.ReadLine();
            Console.Clear();
        }

        static void StringsHaveLengthAndIndexes()
        {
            string name = "Eric";

            // we can access single characters similar to arrays 
            Console.WriteLine("first letter: {0}", name[0]);

            // print my name backwards, don't forget -1 on length (indexes start at 0)
            for (int i = name.Length-1; i >=0; i--)
            {
                Console.Write("{0}", name[i]);
            }
            Console.WriteLine();

            //Substring takes a string apart
            
            //One number gets a string after the index
            Console.WriteLine("Everything at or after position 1: {0}", name.Substring(1));

            //Two numbers starts at a position and reads the next N characters
            Console.WriteLine("The last two characters: {0}", name.Substring(name.Length-2,2));

            Console.ReadLine();
            Console.Clear();
        }

        static void CasingAndWhiteSpace()
        {
            string s1 = ""; // no data here - empty string

            Console.WriteLine("Does the string have data? {0}", string.IsNullOrEmpty(s1)); //commonly used method/function, if you pass a string into this it will return true or false based on whether the string has data in it or is null

            s1 = "AbCdEfG";
            Console.WriteLine("{0}  ToUpper: {1}   ToLower: {2}", s1, s1.ToUpper(), s1.ToLower());

            Console.ReadLine();
            Console.Clear();
        }

        static void UsefulCharacterMethods()
        {
            char c1 = 'a'; //character class has lots of built-in methods that can be used to evaluate user data 

            Console.WriteLine("The character: {0}", c1);
            Console.WriteLine("IsDigit: {0}", char.IsDigit(c1));
            Console.WriteLine("IsLetter: {0}", char.IsLetter(c1));
            Console.WriteLine("IsLetterOrDigit: {0}", char.IsLetterOrDigit(c1));
            Console.WriteLine("IsLower: {0}", char.IsLower(c1));
            Console.WriteLine("IsUpper: {0}", char.IsUpper(c1));
            Console.WriteLine("IsPunctuation: {0}", char.IsPunctuation(c1));
            Console.WriteLine("IsWhiteSpace: {0}", char.IsWhiteSpace(c1));

            Console.ReadLine();
            Console.Clear();
        }

        private static void EditingStrings()
        {
            string s1 = "   Got some extra spaces?    ";
            s1 = s1.Trim();

            Console.WriteLine(s1);

            s1 = s1.Replace("Got", "Have");
            Console.WriteLine(s1);

            Console.ReadLine();
            Console.Clear();
        }

        static void SplitAndJoin() //most commonly used when using flat file transfers or dealing with data from other systems
        {
            string s1 = "This is a sentence";

            // split() takes a character to separate a string into an array
            // the character to split on is called a DELIMETER
            string[] words = s1.Split(' '); // split on space

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            // Join can take a string array and put it back together
            string s2 = string.Join(",", words);
            Console.WriteLine(s2); // all the words separated by commas instead of spaces

            Console.ReadLine();
            Console.Clear();
        }
    }
}
