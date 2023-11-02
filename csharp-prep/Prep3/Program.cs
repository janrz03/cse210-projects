using System;

class Program
{
    static void Main(string[] args)
    {
        // asked for magin number
       // Console.Write("Please type the magic number: ");
        //int num = int.Parse(Console.ReadLine());
        int guess = -1;

        // generating random numbers
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 101);

        while (guess != num)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if ( num > guess)
            {
                Console.WriteLine("Higher");

            }
            else if (num < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            } 

        }
    }
}