public class Activity{
    private string _newActivity;
    private int _designatedTime;
    
    private string _text;

    
    //constructor
    public Activity(){}

    //first method used to load the activity string to variable
    public Activity(string newActivity){
        _newActivity = newActivity;
        _text = "You may start in: ";
    }
    //second method used to show the user the welcome message
    public void WelcomeActivityMessage(){
        Console.WriteLine($"Welcome to the {_newActivity} Activity\n");
    }

    //second method used to get the time in seconds from the user 
    public int GetActivityTime(){
        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        _designatedTime = seconds;
        return seconds;
    }

    // third method used to showed the animation of waiting process
    public void DisplayAnimationReady(){
      
         Console.WriteLine("Get Ready... ");
            for (int i=0; i<10; i++){
                List<string>animationString = new List<string>();
                animationString.Add("|");
                animationString.Add("/");
                animationString.Add("-");
                animationString.Add("\\");
                foreach (string s in animationString){
                    Console.Write(s);
                    Thread.Sleep(500);
                    Console.Write("\b \b");  
                } 
            }
    }
    // fourth method used to show the final message 
    public void DisplayFinalMessage(){
       
            Console.Write("\nWell done ");
            for (int i=0; i<10; i++){
                List<string>animationString = new List<string>();
                animationString.Add("|");
                animationString.Add("/");
                animationString.Add("-");
                animationString.Add("\\");
                foreach (string s in animationString){
                    Console.Write(s);
                    Thread.Sleep(500);
                    Console.Write("\b \b");          
            }     
        }
        Console.WriteLine($"Good job! You have completed another {_designatedTime} seconds of the {_newActivity} Activity!");
    }

    // fifth method used to show another animation 
    public void DisplayAnimation(){
     

        for (int i=0; i<10; i++){
            List<string>animationString = new List<string>();
            animationString.Add("|");
            animationString.Add("/");
            animationString.Add("-");
            animationString.Add("\\");
            foreach (string s in animationString){
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");    
            }
        }
     
        }
    
    public void DisplayCounter(int time){
        for (int i = time; i > 0; i--){
            Console.Write($"{_text} {i}");
            Thread.Sleep(1000);
            string space = new string('\b',  (_text.Length +5) );
            Console.Write(space);
        }
        Console.WriteLine("");
        //Console.WriteLine($"Go:     ");
    }

    
}