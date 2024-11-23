using System.Dynamic;

public abstract class Goal
{
    public string Name { get; private set; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set;}
    
    public Goal( string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public abstract int RecordProgress();
    public abstract string DisplayGoal();
}

