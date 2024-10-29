 using System;
using System.Threading;
 
 public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.")
    {

    }

    public override void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            elapsed += 5;

            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
            elapsed += 5;
        }
        DisplayEndingMessage();
    }
}
