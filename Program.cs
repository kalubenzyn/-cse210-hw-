using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("03 Nov 2022", 45, 15.0),
            new Swimming("03 Nov 2022", 40, 30)
        };

        // Display summaries of each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

// Abstract base class for activities
abstract class Activity
{
    public string Date { get; set; }
    public int Duration { get; set; } // Duration in minutes

    public Activity(string date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    // Abstract method to be implemented by derived classes
    public abstract string GetSummary();
}

// Running activity class
class Running : Activity
{
    public double Distance { get; set; } // Distance in kilometers

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }

    public override string GetSummary()
    {
        return $"{Date} Running: {Duration} min, {Distance} km";
    }
}

// Cycling activity class
class Cycling : Activity
{
    public double Speed { get; set; } // Speed in km/h

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        Speed = speed;
    }

    public override string GetSummary()
    {
        return $"{Date} Cycling: {Duration} min, {Speed} km/h";
    }
}

// Swimming activity class
class Swimming : Activity
{
    public int Laps { get; set; } // Number of laps

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

    public override string GetSummary()
    {
        return $"{Date} Swimming: {Duration} min, {Laps} laps";
    }
}