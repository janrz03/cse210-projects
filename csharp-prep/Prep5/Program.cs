using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Welcome to the program!
        // Please enter your name: Brother Burton
        // Please enter your favorite number: 42
        // Brother Burton, the square of your number is 1764

        // 1. Write and test the program as described above.

        DisplayWelcome();
        string user = PromptUserName();
        int num = PromptUserNumber();
        int squa = SquareNumber(num);
        DisplayResult(user, squa);

        // first funtion
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        } 
        // second funtion
        static string PromptUserName()
        {
            Console.Write("Please type your name: ");
            string name = Console.ReadLine();
            return name;
        }
        // third funtion
        static int PromptUserNumber()
        {
            Console.Write("Please type your favorite number: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        static int SquareNumber(int num)
        {
           int square = num * num;
           return square;
        }
        //fith funtion
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {square}");
        }
         
    }      

}