using System;
using System.Net;

public class MemorizeScripture
{
    public Scripture _reference;
    public List<Verse> _verses = new List<Verse>();
    
    // Constructors
    public MemorizeScripture(Scripture reference, List<Verse> verses)
    {
        _reference = reference;
        _verses = verses;
    }
    public void Display()
    {
        _reference.Display();
        foreach (var verse in _verses)
        {
            verse.Display();
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    public void HideThreeRandomWords()
    {
        Random rand = new Random();
        int wordsHidden = 0;

        while (wordsHidden < 3)
        {
            int verseIndex = rand.Next(_verses.Count);
            var selectedVerse = _verses[verseIndex];

            if (selectedVerse.HideRandomWord())
            {
                wordsHidden++;
            }
        }
    }
}
