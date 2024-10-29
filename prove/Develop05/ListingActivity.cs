using System;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(_prompts.Count)]); // Show random prompt

        Console.WriteLine("You may begin in:");
        ShowCountDown(4);

        DateTime startTime = DateTime.Now;
        List<string> items = new List<string>();

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }
        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }
}
