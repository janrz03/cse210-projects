using System.Diagnostics;
using System.Globalization;

    public class ListingActivity : Activity {
    
    private List<string> _userPrompt = new List<string>();

        private static string[] _randomPrompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private List<string> _listingPrompt = new List<string>(_randomPrompts);
    private string _thirdMessage;

    public ListingActivity(string newActivity): base(newActivity){
        _thirdMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void SetThirdMessage(){
        Console.WriteLine($"{_thirdMessage}\n");
        
    }

    public ListingActivity(): base(){}

    public string GetRandomPrompt()
    {
        var random = new Random();
        int number = random.Next(_listingPrompt.Count);
        string Promts = _listingPrompt[number];
        return Promts;
    }

    public void DisplayRandomPrompt(int time){
        var ask = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"--- {ask} ---");
        DisplayCounter(8);
        ShowTimeCounter(time);
    }

    public void ShowTimeCounter(int time){
        Stopwatch clock =  new Stopwatch();
        clock.Start();
        while (clock.Elapsed.TotalSeconds < time){
            Console.Write("> ");
            _userPrompt.Add(Console.ReadLine());
        }
        clock.Stop();
        int answerLength = _userPrompt.Count;
        Console.WriteLine($"You have listed {answerLength} items");

    }

}