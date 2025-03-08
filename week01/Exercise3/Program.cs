using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = 0;
        while (guess != number)
        {
        Console.Write("What is your guess? ");
        string gues = Console.ReadLine();
        guess = int.Parse(gues);

        if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < number)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed right!!!");
        }
        }
    }
}