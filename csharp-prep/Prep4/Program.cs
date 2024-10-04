using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

         List <int> numbers = new List<int> ();

         int usNumber = -1;
         while (usNumber != 0)
         {
            Console.WriteLine("Enter a number: ");
            
            string usResponse = Console.ReadLine();
            usNumber = int.Parse(usResponse);
            
            
            if (usNumber != 0)
            {
                numbers.Add(usNumber);
            }
         }

       int sum = 0;
       foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

         float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

         int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");


    }
}