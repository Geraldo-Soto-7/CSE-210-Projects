using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Eternal Quest!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create a New Goal");
            Console.WriteLine("5. Record an Event (Complete a Goal)");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    manager.DisplayPlayerInfo();
                    Pause();
                    break;
                
                case "2":
                    Console.Clear();
                    manager.ListGoalNames();
                    Pause();
                    break;

                case "3":
                    Console.Clear();
                    manager.ListGoalDetails();
                    Pause();
                    break;

                case "4":
                    Console.Clear();
                    manager.CreateGoal();
                    Pause();
                    break;

                case "5":
                    Console.Clear();
                    manager.RecordEvent();
                    Pause();
                    break;

                case "6":
                    Console.Clear();
                    manager.SaveGoals();
                    Pause();
                    break;

                case "7":
                    Console.Clear();
                    manager.LoadGoals();
                    Pause();
                    break;

                case "8":
                    running = false;
                    Console.WriteLine("Thank you for using Eternal Quest! Goodbye.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose a valid number.");
                    Pause();
                    break;
            }
        }
    }

    static void Pause()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}
