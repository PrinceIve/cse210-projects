using System;

class Program
{ static List<string> entries = new List<string>();
    static string filePath = "journal.txt";

    static void Main()
    {
        LoadEntries();

        while (true)
        {
            Console.WriteLine("\n1. Write Entry\n2. View Entries\n3. Save and Exit");
            string choice = Console.ReadLine();

            if (choice == "1") AddEntry();
            else if (choice == "2") ViewEntries();
            else if (choice == "3") { SaveEntries(); break; }
            else Console.WriteLine("Invalid choice.");
        }
    }

    static void AddEntry()
    {
        Console.Write("Enter a journal prompt: ");
        string prompt = Console.ReadLine();
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string entry = $"{DateTime.Now:yyyy-MM-dd} | {prompt} | {response}";
        entries.Add(entry);
    }

    static void ViewEntries()
    {
        if (entries.Count == 0) Console.WriteLine("No entries yet.");
        else foreach (var entry in entries) Console.WriteLine(entry);
    }

    static void SaveEntries() => File.WriteAllLines(filePath, entries);

    static void LoadEntries() { if (File.Exists(filePath)) entries.AddRange(File.ReadAllLines(filePath)); }
}