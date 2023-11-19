using System;


public class Scripture 
{
    //Setting variables
    
    private static string[] _scriptVerses = {
    
    "16 God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
     "5 Trust in the Lord with all thine heart, and lean not unto thine own understanding. 6. In all thy ways acknowledge him, and he shall direct thy paths.",
    "17 Even so faith, if it hath not works, is dead, being alone. 18 Yea, a man may say, Thou hast faith, and I have works: shew me thy faith without thy works, and I will shew thee my faith by my works.",
    "10 That in the dispensation of the fulness of times he might gather together in one all things in Christ, both which are in heaven, and which are on earth; even in him:",
     "11 Nevertheless neither is the man without the woman, neither the woman without the man, in the Lord."
     };

    private List<string> _verses = new List<string>(_scriptVerses);

    public Scripture(){}
 
   // Method used to set the variable capture in program that came from Reference class
   public string SetindexScripture(int reference)
    {
        int _indexRef = reference; //this variable is the index that match with the relation between reference and scriptures arrays.
        string Verses = _verses[_indexRef];
        return Verses;
    }

}