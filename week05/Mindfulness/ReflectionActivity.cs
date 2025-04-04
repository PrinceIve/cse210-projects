using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> prompts;
    private List<string> questions;

    public ReflectionActivity() 
        : base("Reflection Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. It will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        // Example prompts for reflection
        prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Example questions for reflection
        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        StartMessage();

        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {selectedPrompt}");

        // Asking reflection questions
        int secondsRemaining = duration;
        int questionIndex = 0;

        while (secondsRemaining > 0 && questionIndex < questions.Count)
        {
            Console.WriteLine("\nReflect on this question:");
            Console.WriteLine(questions[questionIndex]);
            ShowSpinner(3);  // Pause for 3 seconds (can be adjusted)
            secondsRemaining -= 3;
            questionIndex++;
        }

        EndMessage();
    }
}
