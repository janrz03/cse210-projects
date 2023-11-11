public class Entry{

    // Setting variables in class dedicated to entries
    public string _dateTime = "";
    public string _userPrompt = "";
    public string _userEntry = "";

    // Contructor
    public Entry(){}

    // Method used to display the inputs type with the promts, selecting option 2
    public void Display(){
        Console.WriteLine($"Date: {_dateTime} - Prompt: {_userPrompt}\n {_userEntry}\n");                       
    }
}