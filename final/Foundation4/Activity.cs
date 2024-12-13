using System;

abstract class Activity
{
    private string _date;
    private int _duration; // Duration in minutes

    protected Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string Date => _date;
    public int Duration => _duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        return $"{Date}: {GetType().Name} ({Duration} min): Distance {distance:F2} km, Speed {speed:F2} kph, Pace {pace:F2} min per km";
    }
}