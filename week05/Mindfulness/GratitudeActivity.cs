using System;
using System.Collections.Generic;
using System.Threading;

public class GratitudeActivity : Activity
{
    private List<string> prompts;

    public GratitudeActivity()
        : base("Gratitude Activity", 
               "This activity will help you reflect on the things you are grateful for, helping you focus on positivity and gratitude in your life.")
    {
        // Example prompts for gratitude
        prompts = new List<string>
        {
            "What are you grateful for today?",
            "Who in your life are you thankful for?",
            "What is something small that you are grateful for?",
            "What opportunities are you grateful for?",
            "What positive things happened this week that you're grateful for?"
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

        List<string> userGratitudes = new List<string>();
        int secondsRemaining = duration;
        while (secondsRemaining > 0)
        {
            Console.WriteLine("\nType your next thing you're grateful for or press Enter to finish.");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                userGratitudes.Add(item);
            }
            else
            {
                break;  // Allow user to press Enter to finish early
            }
            secondsRemaining--;
        }

        // Show the number of things they are grateful for
        Console.WriteLine($"\nYou listed {userGratitudes.Count} things you're grateful for.");
        EndMessage();
    }
}
