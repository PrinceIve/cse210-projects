using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();  // Step 1: Show welcome message
        
        string userName = PromptUserName();  // Step 2: Get user's name
        int userNumber = PromptUserNumber(); // Step 3: Get user's favorite number
        int squared = SquareNumber(userNumber); // Step 4: Square the number

        DisplayResult(userName, squared); // Step 5: Show final result
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
