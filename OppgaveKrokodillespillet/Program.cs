using System;

namespace OppgaveKrokodillespillet
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            MyConsole.Introduction();
           
            while (true)
            {
                int[] numbers = GetNewNumbers();

                Console.WriteLine();
                Console.WriteLine($"{numbers[0]}_{numbers[1]}");

                char userInput = MyConsole.AskForInput();

                if (userInput != '<' && userInput != '>' && userInput != '=')
                {
                    Console.WriteLine();
                    Console.WriteLine($"Game ended, final score: {counter}");
                    break;
                }
                else if (numbers[0] > numbers[1] && userInput == '>')
                {
                    Console.WriteLine("Correct!");
                    counter++;

                }
                else if (numbers[0] < numbers[1] && userInput == '<')
                {
                    Console.WriteLine("Correct!");
                    counter++;
                }
                else if (numbers[0] == numbers[1] && userInput == '=')
                {
                    Console.WriteLine("Correct!");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Incorrect answer :(");
                    if (counter > 0)
                    {
                        counter--;
                    }
                }
                Console.WriteLine($"Current score is {counter}");
                Console.WriteLine();
            }
        }
        static int[] GetNewNumbers()
        {
            var rand = new Random();

            return new int[] { rand.Next(12), rand.Next(12) };
        }
    }
}