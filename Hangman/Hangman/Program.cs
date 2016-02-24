using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            HangmanGame game = new HangmanGame();
            game.Play();

            Console.ReadLine();
        }
    }
}
