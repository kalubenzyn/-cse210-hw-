public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public string Date => _date;
    public int LengthMinutes => _lengthMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
