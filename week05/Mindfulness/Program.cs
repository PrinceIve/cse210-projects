using System;

class Program
{
    static void Main(string[] args)
    {
        ActivityLog activityLog = new ActivityLog();  // Log instance to keep track of activity counts

        while (true)
        {
            Console.WriteLine("\nMindfulness Program Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. View Activity Log");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                activityLog.LogActivity("Breathing Activity");  // Log the activity
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                activityLog.LogActivity("Reflection Activity");  // Log the activity
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                activityLog.LogActivity("Listing Activity");  // Log the activity
            }
            else if (choice == "4")
            {
                GratitudeActivity gratitude = new GratitudeActivity();
                gratitude.Run();
                activityLog.LogActivity("Gratitude Activity");  // Log the activity
            }
            else if (choice == "5")
            {
                activityLog.DisplayLog();  // Display the activity log
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}
