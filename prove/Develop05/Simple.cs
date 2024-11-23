public class Simple : Goal
{
    public Simple(string name, int points): base(name, points) { }

    public override int RecordProgress()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;
        }
        return 0;
    }

    public override string DisplayGoal()
    {
        return $"[{(IsCompleted ? "X" : " ")} ] {Name} ({Points} points)";
    }
}