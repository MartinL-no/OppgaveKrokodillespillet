using System;

namespace OppgaveKrokodillespillet
{
    public class MyConsole
    {
        public static void Introduction()
        {
            Console.WriteLine("Welcome to the crocodile game");
            Console.WriteLine("How to play: Two numbers between 0-11 will be shown, choose which is bigger (or equal) using the '<', '>' or '=' characters");
            Console.WriteLine("eg: 3<5");
        }
        public static char AskForInput()
        {
                Console.Write("Answer: ");
                var userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();

                return userInput;
        }
    }
}

