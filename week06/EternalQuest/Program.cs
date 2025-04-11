using System;

public class Program
{
    public static void Main()
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Show Goals");
            Console.WriteLine("6. Show Points and Rank");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter points: ");
                int points = int.Parse(Console.ReadLine());
                manager.CreateSimpleGoal(name, points);
            }
            else if (input == "2")
            {
                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter points: ");
                int points = int.Parse(Console.ReadLine());
                manager.CreateEternalGoal(name, points);
            }
            else if (input == "3")
            {
                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter points: ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("Enter target count: ");
                int count = int.Parse(Console.ReadLine());
                manager.CreateChecklistGoal(name, points, count);
            }
            else if (input == "4")
            {
                Console.WriteLine("Select a goal to record:");
                for (int i = 0; i < manager.Goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {manager.Goals[i].Name}");
                }
                int choice = int.Parse(Console.ReadLine()) - 1;
                manager.RecordGoalEvent(choice);
            }
            else if (input == "5")
            {
                manager.DisplayGoals();
            }
            else if (input == "6")
            {
                manager.DisplayPointsAndRank();
            }
            else if (input == "7")
            {
                break;
            }
        }
    }
}

// Exceeded requirements by adding a creative ranking system based on points:
// - The GetRank method now determines the user's rank based on total points accumulated.
// - Introduced ranks such as "Master Achiever", "Goal Crusher", and "Goal Getter" to reflect different levels of achievement.
// - Added an "Aspiring Achiever" rank to encourage early progress and reward users for their efforts as they start their journey.
// - This gamification approach enhances user engagement by providing a clear sense of progression and rewards for goal completion.
// - The ranking system makes the experience feel more interactive and dynamic, motivating users to aim for higher ranks and achieve more.
