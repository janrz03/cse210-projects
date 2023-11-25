using System;

    class Program
    {
        static void Main(string[] args)
        {
            
            Assignment Assignment1 = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine(Assignment1.GetSummary());
            Console.WriteLine("");
            MathAssignment MathA2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine(MathA2.GetSummary());
            Console.WriteLine(MathA2.GetHomeworkList());
            Console.WriteLine("");
            WritingAssignment WritingA1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(WritingA1.GetSummary());
            Console.WriteLine(WritingA1.GetWritingInformation());
        }
    }