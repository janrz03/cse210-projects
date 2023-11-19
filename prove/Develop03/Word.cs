public class Words{

    //Setting variables
    private string _letters = "";
    private string[] _answer;
    private List<int> _hide = new List<int>();

    //Constructor
    public Words(){}

    //Method used to set scriptures'verses to internal variable and then to convert string into array
    public void SetScriptureVerses(string scripture)
    {
       _letters = scripture;
       _answer = _letters.Split(" ");
      // _hide = new List<int>();
    }
    //Method used to get internal variable from program    
    public int GetHideValue()
    {
        int value = _hide.Count;
        return value;
    }
    //Method used to get internal variable from program  
    public int GetVersesValue()
    {
        int value = _answer.Length;
        return value;
    }
    //Method used to alternate between options to continue with program or quit
    public void Response(){
        var input = Console.ReadLine();    
        if (input.ToLower() == "quit"){
            Environment.Exit(0);
        }
        if (input == ""){
            RamdomWordinVerses();
        }
    }
    // Method used to get ramdom word from verses used to hide them form user
    public void RamdomWordinVerses(){


        var random = new Random();
        Words w = new Words();
        int wordIndex1 = random.Next(_answer.Length);
        int wordIndex2 = random.Next(_answer.Length);
        if (_hide.Contains(wordIndex1) || _hide.Contains(wordIndex2) ){ //!= _hide.Contains(key3)
            RamdomWordinVerses();  
        }
        else{
            _hide.Add(wordIndex1);
            _hide.Add(wordIndex2);
            
        }
    }

        
    //Method configured to show changing text to user
    public void Show(string text, string reference){
        //_vers = text;
        Console.Clear();
        Console.Write($"{reference}: ");
        //Console.WriteLine($" {_reference} ");
        
        for (var i=0; i<_answer.Length ; i++){
            var eachWord = _answer[i];
            int len = eachWord.Length;
            string underlineReplace = new string('_', len);
            if (_hide.Contains(i)){
                Console.Write($" {underlineReplace} ");
            }
            else{
                Console.Write($" {eachWord} ");    
            }     
        }
        Console.Write("\n\nPress enter to continue or type 'quit' to finish: ");
    }
    
}