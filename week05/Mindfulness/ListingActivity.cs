using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> prompts;

    public ListingActivity() 
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        // Example prompts for listing
        prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        StartMessage();

        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {selectedPrompt}");

        // Countdown before starting
        ShowCountdown(5);  // Give the user 5 seconds to think

        List<string> userList = new List<string>();
        int secondsRemaining = duration;
        while (secondsRemaining > 0)
        {
            Console.WriteLine("\nType your next item or press Enter to finish.");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                userList.Add(item);
            }
            else
            {
                break;  // Allow user to press Enter to finish early
            }
            secondsRemaining--;
        }

        // Show the number of items listed
        Console.WriteLine($"\nYou listed {userList.Count} items.");
        EndMessage();
    }
}
