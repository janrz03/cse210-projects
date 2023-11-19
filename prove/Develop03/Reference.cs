using System;
using System.Globalization;
public class Reference{

    // Setting variables

    private int _indexRef;
    private static string[] _scriptRef = {"John 3:16", "Proverbs 3: 5-6", "James 2:17-18", "Ephesians 1:10", "1 Corinthians 11:11"};
    private List<string> _references = new List<string>(_scriptRef);


    // Constructor
    public Reference(){}

    //First method used to get from programs the index value in a variable used such in this class and also in reference class
    public int GetReference(){

        var random = new Random();
        Reference r = new Reference();
        int _number = random.Next(_references.Count);
        return _number;
        
        
    }

   //Second method configured to Set the variable capture in program to get the index value in list
   public string SetRamRef(int reference)
    {
        Reference r = new Reference();
        _indexRef = reference;
        string Reference = _references[_indexRef];
        return Reference;
    }

    
}