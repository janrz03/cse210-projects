using System;

class Program
{
    static void Main(string[] args)
    {


    int _num = 0;
    while(_num !=5)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("\nMenu options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("5. Quit");
        Console.Write("\nSelect a choice from the menu: ");
        string answer = Console.ReadLine();
        int num = int.Parse(answer);


        Console.Clear();
        switch (num){
            case 1:
                Console.Clear();
                BreathingActivity breath = new BreathingActivity("Breathing");
                breath.WelcomeActivityMessage();
                breath.SetOpeningMessage();
                int time = breath.GetActivityTime();
                Console.Clear();
                breath.DisplayAnimationReady();
                breath.Breath(time);
                breath.DisplayFinalMessage();
            break;

            case 2:
                Console.Clear();
                ReflectingActivity reflect = new ReflectingActivity("Reflecting");
                reflect.WelcomeActivityMessage();
                reflect.SetSecondMessage();
                time = reflect.GetActivityTime();
                Console.Clear();        
                reflect.DisplayAnimationReady();
                num = reflect.GetIndexQuestions();
                reflect.InquireQuestions(num);
                reflect.DisplayInstructions(time);
                reflect.DisplayFinalMessage();
            break;

            case 3:
                Console.Clear();
                ListingActivity listing = new ListingActivity("Listing");
                listing.WelcomeActivityMessage();
                listing.SetThirdMessage();
                time = listing.GetActivityTime();
                Console.Clear(); 
                listing.DisplayAnimationReady();
                //listing.LoadWords();
                listing.DisplayRandomPrompt(time);
                listing.DisplayFinalMessage();
            break;

            case 4:
                Console.Write("Good Bye!");
            break;

            default:
                Console.Write("Not a valid option");
            break;
        }
    }


    }
}