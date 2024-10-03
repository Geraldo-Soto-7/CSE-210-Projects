using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2
       //Console.WriteLine("What is the magic number?");
       //int number = int.Parse(Console.ReadLine());

        // For Parts 3
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

       int guess_num = -1;

       while (guess_num != number)
       {
        Console.WriteLine("What is your guess?");
        guess_num = int.Parse(Console.ReadLine());

       if(guess_num > number)
       {
         Console.WriteLine(" Lower ");
       }

       else if(guess_num < number)
       {
         Console.WriteLine(" Higher ");
       }

       else 
       {
         Console.WriteLine("You guess it! ");
       }

       }


    }
}