public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed() => _speed;
    public override double GetDistance() => (_speed * LengthMinutes) / 60;
    public override double GetPace() => 60 / _speed;
}
