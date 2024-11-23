public class Checklist : Goal
{
    private int TimesRequired;
    private int TimesCompleted;
    private int BonusPoints;

    public Checklist(string name, int points, int timesRequired, int bonusPoints)
        : base(name, points)
    {
        TimesRequired = timesRequired;
        TimesCompleted = 0;
        BonusPoints = bonusPoints;
    }

    public override int RecordProgress()
    {
        if (IsCompleted) return 0;

        TimesCompleted++;
        if (TimesCompleted >= TimesRequired)
        {
            IsCompleted = true;
            return Points + BonusPoints;
        }

        return Points;
    }

    public override string DisplayGoal()
    {
        return $"[ {(IsCompleted ? "X" : " ")} ] {Name} ({Points} points, {TimesCompleted}/{TimesRequired} completed)";
    }
}