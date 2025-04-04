using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", 
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        StartMessage();

        int secondsRemaining = duration;
        while (secondsRemaining > 0)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(4);
            secondsRemaining -= 4;

            if (secondsRemaining <= 0) break;

            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
            secondsRemaining -= 4;
        }

        EndMessage();
    }
}
