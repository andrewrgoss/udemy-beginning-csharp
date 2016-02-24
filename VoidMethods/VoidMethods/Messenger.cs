using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethods
{
    /*
    1. Access Level- Who can call the method?
    2. Return Type- Does the method return any data?  If so, what kind of data? (ex. void (line 18))
    3. Name- What name should other code blocks use to run the method?
    4. Parameters- What data needs to be given to the method to do its job? You must have parenthesis for every method definition.
    5. Code Block- What statements should be run when the method is called?
    */
    class Messenger
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World");
        }
    }
}
