using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "DataBase Engineer";
        job1._company = "Google";
        job1._startYear = 2016;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "VMware";
        job2._startYear = 2019;
        job2._endYear = 2023;
        //step 4 Test your job class 
        //Console.WriteLine($"{job1._company}");
        //Console.WriteLine($"{job2._company}");

        //Step 5 Add a Display method 
        //job1.Display(); 
        //job2.Display(); 

        Resume myResume = new Resume();
        myResume._name = "Marcos Perez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Step 7 Test your Resume class
        //Console.WriteLine($"{myResume._jobs[0]._jobTitle}");

        //Step 8 Add a Display method to the Resume class
        myResume.Display();
    }
}