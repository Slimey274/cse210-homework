using System;

// Parent class
public class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting {Name} activity...");
        Console.WriteLine(Description);
    }
        protected void ShowSpinner(int durationInSeconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;

        for (int i = 0; i < durationInSeconds * 4; i++)
        {
            Console.Write(spinner[spinnerIndex]);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            Thread.Sleep(250);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
}