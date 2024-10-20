using System;

class Program
{
    static void Main(string[] args)
    {
        // Example scripture: Proverbs 3:5-6
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.");

       
        while (!scripture.IsCompletelyHidden())
        {
            // Clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt the user to press enter or type "quit"
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                break;
            }

           
            scripture.HideRandomWords(3);
        }

        // End the program once all words are hidden
        Console.Clear();
        Console.WriteLine("All words are hidden. Program ended.");
    }
}