using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made me smile today?",
        "What is one thing I learned today?",
        "What challenge did I overcome today?",
        "Who did I help today?",
        "What am I grateful for today?"
    };

    static List<Entry> journal = new List<Entry>();

    class Entry
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

        public override string ToString()
        {
            return $"{Date},\"{Prompt}\",\"{Response.Replace("\"", "\"\"")}\"";
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. View Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1") WriteEntry();
            else if (choice == "2") ViewEntries();
            else if (choice == "3") SaveJournal();
            else if (choice == "4") LoadJournal();
            else if (choice == "5") break;
            else Console.WriteLine("Invalid option. Try again.");
        }
    }

    static void WriteEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        journal.Add(new Entry { Date = DateTime.Now.ToShortDateString(), Prompt = prompt, Response = response });
    }

    static void ViewEntries()
    {
        if (journal.Count == 0) Console.WriteLine("No entries found.");
        else foreach (var entry in journal) Console.WriteLine($"{entry.Date}: {entry.Prompt}\n{entry.Response}\n");
    }

    static void SaveJournal()
    {
        Console.Write("Enter filename (e.g., journal.csv): ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in journal) writer.WriteLine(entry);
        }

        Console.WriteLine("Journal saved.");
    }

    static void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        journal.Clear();
        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split(new[] { ',' }, 3);
            if (parts.Length == 3)
            {
                journal.Add(new Entry { Date = parts[0], Prompt = parts[1].Trim('"'), Response = parts[2].Trim('"').Replace("\"\"", "\"") });
            }
        }

        Console.WriteLine("Journal loaded.");
    }
}
