using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade points? ");
        string points = Console.ReadLine();
        int grade = int.Parse(points);
        string letter = "i";

        if (grade >= 90)
        {
            // Console.WriteLine("Your grade is: A");
            letter = "A";
        }
        else if (grade >= 80)
        {
            // Console.WriteLine("Your grade is: B");
            letter = "B";
        }
        else if (grade >= 70)
        {
            // Console.WriteLine("Your grade is: C");
            letter = "C";
        }
        else if (grade >= 60)
        {
            // Console.WriteLine("Your grade is: D");
            letter = "D";
        }
        else 
        {
            // Console.WriteLine("Your grade is: F");
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");         
        }
        else
        {
             Console.WriteLine("Thanks for your efforts, better luck the next time");
             
        }

    

    }
}