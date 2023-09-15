using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess;

        do {
        Console.WriteLine("What is your guess? ");
        string stringGuess = Console.ReadLine();
        guess = int.Parse(stringGuess);

        if (guess > number) {
            Console.WriteLine("Lower");
        }
        else if (guess < number) {
            Console.WriteLine("Higher");
        }
        else {
            Console.WriteLine("You guessed it!");
        }

        } while (guess != number);
    }
}