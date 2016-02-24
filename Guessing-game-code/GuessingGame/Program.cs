using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerGuess;
            int numGuesses;
            string playerInput;
            bool isNumberGuessed = false;
            int theAnswer;

            Random rng = new Random();
            theAnswer = rng.Next(1, 21);
            numGuesses = 0;

            do
            {
                Console.Write("Enter your guess: ");
                playerInput = Console.ReadLine();

                playerGuess = int.Parse(playerInput);

                if (playerGuess == theAnswer)
                {
                    Console.WriteLine("You got it! Number of guesses = {0}", numGuesses);
                    isNumberGuessed = true;
                }
                
                if (playerGuess > 20)
                {
                    Console.WriteLine("Invalid guess");
                }

                else
                {
                    if (playerGuess > theAnswer)
                    {
                        Console.WriteLine("Too high!");
                        numGuesses++;
                    }
                    else
                    {
                        Console.WriteLine("Too low!");
                        numGuesses++;
                    }
                }

            } while (!isNumberGuessed);

            Console.ReadLine();
        }
    }
}
