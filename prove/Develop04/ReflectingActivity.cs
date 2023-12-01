using System.Diagnostics;

public class ReflectingActivity: Activity{


    //set variables
    private static string[] _inquireList = {"How can you keep this experience in mind in the future?", "What did you learn about yourself through this experience?", "What could you learn from this experience that applies to other situations?", "What is your favorite thing about this experience?", "What made this time different than other times when you were not as successful?", "How did you feel when it was complete?", "How did you get started?", "Have you ever done anything like this before?", "Why was this experience meaningful to you?"};
    private List<string> _inquire = new List<string>(_inquireList);

    private static string[] _reflectingpromts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _reflecPromts = new List<string>(_reflectingpromts);

    private List<int> _index = new List<int>();


    private string _reflectingMessage;
    //contructor
    public ReflectingActivity():base(){}

    public ReflectingActivity(string newActivity): base(newActivity){
        _reflectingMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    //method used to show main message for reflecting option
    public void SetSecondMessage(){
        Console.WriteLine($"{_reflectingMessage}\n");
    }

    //method used to get the ramdom reflecting question
    public string RamdomReflecting()
    {
        var random = new Random();
        int number = random.Next(_reflecPromts.Count);
        string Promts = _reflecPromts[number];
        return Promts;

    }
    public int GetIndexQuestions(){
        var random = new Random();
        int _number = random.Next(_inquire.Count);
        return _number;
    }

    // method used to get the random questions for reflection
    public string InquireQuestions(int _number)
    {
        //var random = new Random();
        //int number = random.Next(_inquire.Count);
        int number = _number;
        string Inquire = _inquire[number];
        return Inquire;
    }

    

    
    //method used to display the instructions and ramdom reflection 
    public void DisplayInstructions(int time){
        var show = RamdomReflecting();
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"\n--- {show} ---\n");
        Console.Write("When you have something in mind, press enter to continue. ");
        string input = Console.ReadLine();
        if (input == ""){
            DisplayQuestion(time);
        }
    }
    //method used to display the questions about reflection
    public void DisplayQuestion(int time){
        
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        DisplayCounter(8);
        Console.Clear();
        Stopwatch clock = new Stopwatch();
        clock.Start();
        while(clock.Elapsed.TotalSeconds < time)
        {
            int num = GetIndexQuestions();
            //if (_inquire.Count != 0){
            if (_index.Contains(num)){
                int n = GetIndexQuestions();
                InquireQuestions (n);
            }

            else { 
                _index.Add(num);
                num = GetIndexQuestions();
                var inquiry = InquireQuestions(num);
                Console.Write($"\n> {inquiry}");
            }
            DisplayAnimation();
        }
        
        clock.Stop();
    }


}
