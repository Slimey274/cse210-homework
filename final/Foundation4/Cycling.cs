using System;

class Cycling : Activity
{
    private double _speed; // Speed in kilometers per hour

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * Duration) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}