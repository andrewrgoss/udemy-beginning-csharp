using system;
using system.IO;

class HelloWorld  //provides blueprint for behavior for a set of objects
{
public static void	Main() //public = scope of procedure 
// static = create instance of class automatically so we can refer to and call main procedure 
// void = no return value 
// main = name of procedure .NET runtime needs this to run the application

	{
		//Display text in the console window
		console.writeline("Hello, World! "); //system = namespace
		//console = class, knows how to work with console window (the DOS prompt)
		//writeline = method of console class. Indicates what we want to do (write text to console window)
		//"HelloWorld" passes text parameter to writeline method 
	}	
}
