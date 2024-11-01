//Gerardo Soto
//CSE210
class Program
{
    static void Main(string[] args)
    {
        // Create instances of each activity
        var running = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        var cycling = new Cycling(new DateTime(2022, 11, 3), 45, 20.0);
        var swimming = new Swimming(new DateTime(2022, 11, 3), 30, 20);

        // Add activities to a list
        var activities = new List<Activity> { running, cycling, swimming };

        // Print summaries of each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}