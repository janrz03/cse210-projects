using System.Text;
using System.IO;


public class Journal{

    //Setting List 
    public List<Entry> _textFile = new List<Entry>();
    //settings variables
    public string _fileName;

    

    // Constructor 
    public Journal(){}
    // First method, used to display the text assigned to List 
    public void Display(){
        //Entry entry = new Entry();
        foreach (Entry ent in _textFile){
            ent.Display();
        }
    }

    
    // Second Method used to create the file
    public void NewFile(){
        Console.Write("\nPlease type the name of the file and add (.txt) at the end: ");
        _fileName = Console.ReadLine();
    
        File.Create(_fileName).Dispose();  
         
        Console.Write("File created\n\n");
        
        SaveFile(_fileName);
        

    }
    // Third method used to save the entries in the file previously created
    public void SaveFile(string _fileName){
        
        using (StreamWriter outputfile = new StreamWriter(_fileName)){
            //Entry en = new Entry();
            foreach (Entry ent in _textFile)
            {
                outputfile.WriteLine($"{ent._dateTime}; {ent._userPrompt}; {ent._userEntry}"); 
            }
        }
    }

    //fourth method used to load the file text into the program list

    public void LoadFile(){
        Console.Write("Please provide file name: ");
        string _fileName = Console.ReadLine();

        string[] currentText = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in currentText)
        {
            string [] parts = line.Split(";");
            Entry ent = new Entry();
            ent._dateTime = parts[0];
            ent._userPrompt = parts[1];
            ent._userEntry = parts[2];

            _textFile.Add(ent);

        } 


    }

    
}