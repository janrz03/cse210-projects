using System;


class Program
{
    static void Main(string[] args)
    {


        // Setting internal variables to Classes
        Journal jour = new Journal();
        Prompts prom = new Prompts();
        int num = 0;
    

        while (num != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("\nWhat would you like to do? ");
            string answer = Console.ReadLine();
            num = int.Parse(answer);

            switch (num)
            {
                case 1: // write

                string timeInfo = DateTime.Now.ToString(); // setting variable use to capture date and time
                string prompt = prom.ShowPrompt(); //setting method from promts, receiving the ramdom question
                Entry ent = new Entry(); // Setting internal variable to Entry Class
                Console.Write($"\n{prompt}\n> "); //printing question received

                string userResp = Console.ReadLine(); // enabling the Read to capture user Entry
                
                ent._userEntry = userResp; //assigning response to variable in Entry Class
                ent._dateTime = timeInfo; // assigning time capture to variable in Entry Class
                ent._userPrompt = prompt; // assigning question from Prompt to variable in Entry Class
                
                jour._textFile.Add(ent); //saving responses in Entry Class inside list in Journal
                Console.Clear();
                break;

                case 2: // display        
                jour.Display(); // calling display method from journal class
                break;

                case 3: // load 
                jour.LoadFile(); // calling method to load file into internal list
                break;

                case 4: //save 
                Console.Clear();
                jour.NewFile(); // calling method to save file
                break;

                case 5: //quit 
                Console.Write("\nBye!");
                break;

                default:
                       Console.Write("Not a valid option");
                break;

            }
            
        }
    }
}