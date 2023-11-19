using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Reference refe = new Reference();
        int num = refe.GetReference();
        string reference = refe.SetRamRef(num);

        Scripture scrip = new Scripture(); 
        string verses = scrip.SetindexScripture(num);

        Words words = new Words();
        words.SetScriptureVerses(verses);

        while(words.GetHideValue() < words.GetVersesValue() ){
            
            words.Show(verses, reference);
            words.Response();
            
        }
        words.Show(verses, reference);
        

    }
}