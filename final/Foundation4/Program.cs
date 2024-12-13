using System;

class Program
{
    static void Main(string[] args)
    {
        var running = new Running("03 Nov 2022", 30, 4.8); // 4.8 km
        var cycling = new Cycling("03 Nov 2022", 60, 20); // 20 kph
        var swimming = new Swimming("03 Nov 2022", 45, 40); // 40 laps

        var activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}