using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        int goodGuess = 0;
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        do
        {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();

            if (magicNumber > int.Parse(guessNumber))
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < int.Parse(guessNumber))
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.Write("CORRECT!");
                goodGuess = 1;
                
            }
        } while (goodGuess == 0);
    }
}