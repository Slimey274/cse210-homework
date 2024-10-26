using System;

class Program
{
    static void Main(string[] args)
    {
        /*Test functionallity of Word */

            // Word myWord = new Word("Behold");
            // myWord.IsRevealed(true); myWord.Display();
            // myWord.Hide();
            // myWord.Display(); Console.WriteLine();

        /* Test functionality of Verse*/
        
            // string sentence = "Behold the mystery of the universe";
            // List<string> wordList = new List<string>(sentence.Split(' '));
            // Verse myVerse = new Verse(wordList);

            // foreach (Word word in myVerse._wordList)
            // {
            //     word.IsRevealed(true);
            // }

            // myVerse.Display();
            // myVerse.HideRandomWord(); 
            // myVerse.Display();
            // Console.WriteLine($"Revealed count: {myVerse.GetRevealedCount()}");
        
        /*Testing Scripture class */

            // Scripture s1 = new Scripture("John", 3, 16, 18);
            // s1.Display(); // Outputs: John 3:16-18

            // Scripture s2 = new Scripture("Genesis", 1, 1);
            // s2.Display(); // Outputs: Genesis 1:1

        /* Final program */

        // Create the scripture reference 
        Scripture _scripture = new Scripture("John", 3, 16);

        // Create the verse content for scripture
        List<string> _scriptureWord = new List<string>
        {
            "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"
        };

        // Create the Verse object
        Verse _scriptureVerse = new Verse(_scriptureWord);

        // Add the verse to a list of verses
        List<Verse> verses = new List<Verse> { _scriptureVerse };
        // Create the MemorizeScripture object
        MemorizeScripture _memorizeScripture = new MemorizeScripture(_scripture, verses);

        // Display the scripture and verse before hiding words
        Console.WriteLine("Original Scripture:");
        foreach (Word word in _scriptureVerse._wordList)
        {
            word.IsRevealed(true);
        }
        _memorizeScripture.Display();

        // Hide three random words
        _memorizeScripture.HideThreeRandomWords();

        // Display the scripture and verse after hiding words
        Console.WriteLine("\nScripture with Hidden Words:");
        _memorizeScripture.Display();

    }
}