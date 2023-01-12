using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome to Magic number, you have to guess it! ");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess;

        do 
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } 
        while (guess != magicNumber);                   
    }
}