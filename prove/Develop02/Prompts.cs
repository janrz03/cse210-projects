using System;
public class Prompts{

    //setting string Array variable with the questions to use in random funtion
    public static string[] _options = {
        "What was my most interering conversation today? ",
        "What was the best part of my day? ",
        "What was the strongest experience I had today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What's on my mind today? "
    };
    // Setting variable to list the array inside.
    public List<string> _prompts = new List<string>(_options);
    // Contructor
    public Prompts(){}
    // method set to random output
    public string ShowPrompt(){

        var random = new Random();
        int number = random.Next(_prompts.Count);
        string Prompts = _prompts[number];
        return Prompts;
        
    }



}