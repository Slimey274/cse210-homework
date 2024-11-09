using System;

public class Listing
{
    private string[] _prompt = {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public void GetPrompt()
    {
        string firstPrompt = _prompt[_random.Next(_prompt.Length)];
        Console.WriteLine(firstPrompt);
        
        List<string> responses = new List<string>();
        string response;

         while (true)
        {
            Console.Write("Your answer: ");
            response = Console.ReadLine();
            if (string.IsNullOrEmpty(response))
            {
                break; // Stop if the user presses Enter without typing anything
            }
            responses.Add(response);
        }

        // Display all responses
        Console.WriteLine("\nYour responses:");
        for (int i = 0; i < responses.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {responses[i]}");
        }
    } 
}