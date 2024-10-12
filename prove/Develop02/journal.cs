using System;
using System.ComponentModel;
using System.IO;
public class Journal
{
 private List<JournalEntry> entries = new List<JournalEntry>();

    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I learned today?",
        "What is one goal I want to accomplish tomorrow?"
    };

    public void CreateEntry()
    {
        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine("Journal Prompt: " + selectedPrompt);
        Console.Write("Your Response: ");
        string response = Console.ReadLine();

        JournalEntry newEntry = new JournalEntry(selectedPrompt, response);
        entries.Add(newEntry);

        Console.WriteLine("Entry added.\n");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.\n");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }

        Console.WriteLine("Journal saved to " + filename + ".\n");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        entries.Clear();  

        using (StreamReader reader = new StreamReader(filename))
        {
            string prompt = "", response = "", line;
            DateTime date = DateTime.Now;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Date:"))
                {
                    date = DateTime.Parse(line.Substring(6));
                }
                else if (line.StartsWith("Prompt:"))
                {
                    prompt = line.Substring(8);
                }
                else if (line.StartsWith("Response:"))
                {
                    response = line.Substring(10);
                    entries.Add(new JournalEntry(prompt, response) { Date = date });
                }
            }
        }

        Console.WriteLine("Journal loaded from " + filename + ".\n");
    }
}