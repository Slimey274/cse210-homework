public class Eternal : Goal
{
    public Eternal(string name, int points) : base(name, points) { }

    public override int RecordProgress()
    {
        return Points;
    }

    public override string DisplayGoal()
    {
        return $"[ ] {Name} ({Points} points each time)";
    }
}