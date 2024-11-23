using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> Goals = new List<Goal>();
    private int Score = 0;

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < Goals.Count)
        {
            Score += Goals[goalIndex].RecordProgress();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i].DisplayGoal()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {Score}");
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(Score);
            foreach (var goal in Goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points},...");
                // Include other goal-specific details here
            }
        }
    }

    public void Load(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                Score = int.Parse(reader.ReadLine());
                Goals.Clear();
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split(',');
                    string type = parts[0];
                    // Recreate goals based on type
                }
            }
        }
    }
}
