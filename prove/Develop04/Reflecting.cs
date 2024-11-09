using System;
using System.Security.Cryptography;

public class Reflecting
{
    private string _refelctingDiscription;
    //prompt one is what the user is first prompted to do
    private string[] _prompt = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
    // prompt two is the second list of prompts for the user
    private string[] _prompt2 = {
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
    // now we will call random
    private Random _random = new Random();
    // This public void will get the random prompts and the user input 
    public void GetPrompt()
    {
        string firstPrompt = _prompt[_random.Next(_prompt.Length)];
        Console.WriteLine(firstPrompt);

        Console.Write("Your answer: ");
        string response1 = Console.ReadLine();

        string secondPrompt = _prompt2[_random.Next(_prompt2.Length)];
        Console.WriteLine(secondPrompt);

        Console.Write("Your answer: ");
        string response2 = Console.ReadLine();

        Console.WriteLine($"\nYour responses:\n1. {response1}\n2. {response2}");
    } 
}