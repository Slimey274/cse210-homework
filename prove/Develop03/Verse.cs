using System;
using System.Collections;

public class Verse 
{
    // Attributes
    public List<Word> _wordList = new List<Word>();

    // Behavior
    public Verse(List<string> words)
    {
        foreach (string word in words)
        {
            _wordList.Add(new Word(word));
        }
    }
    public void Display()
    {
        foreach (var word in _wordList)
        {
            word.Display();
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    public int GetWordCount()
    {
        return _wordList.Count;
    }
    public int GetRevealedCount()
    {
        int revealedCount = 0;
        foreach(var word in _wordList)
        {
            if (word._revealed)
            {
                revealedCount++;
            }
        }
        return revealedCount;
    }
    public void HideWord(int index)
    {
        if (index >= 0 && index < _wordList.Count)
        {
            _wordList[index].Hide();
        }
    }
    public bool HideRandomWord()
    {
        Random rand = new Random();
        List<int> revealedWord = new List<int>();

        for( int i = 0; i < _wordList.Count; i++)
        {
            if (_wordList[i]._revealed)
            {
                revealedWord.Add(i);
            }
        }
        if (revealedWord.Count == 0)
        {
            return false;
        }

        int randomIndex = rand.Next(revealedWord.Count);
        _wordList[revealedWord[randomIndex]].Hide();
        return true;
        
    }
}