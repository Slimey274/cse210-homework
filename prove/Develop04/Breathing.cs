
using System;

public class Breathing : Activity
{
    private string _breathingDescription;
    private string _prompt;

    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void BreathingActivity()
    {
        StartActivity();

        _prompt = "Breathe in ... Breathe out";
        for (int i = 0; i < 3; i++) // Repeat the breathing instructions a few times
        {
            Console.WriteLine(_prompt);
            ShowSpinner(2); // Spinner for each breath cycle
        }
    }
}