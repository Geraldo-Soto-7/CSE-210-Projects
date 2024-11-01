using System;
using System.Collections.Generic;

// Base class for Activity
public abstract class Activity
{
    private DateTime date;
    private int duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date => date;
    public int Duration => duration;

    public abstract double GetDistance(); // in km
    public abstract double GetSpeed(); // in kph
    public abstract double GetPace(); // min per km

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} ({duration} min) - Distance: {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}