using System;

public class Scripture 
{
    //Attributes
    public string _book;
    public int _chapter;
    public int _firstVerse;
    public int _lastVerse;
    
    //Behaviors
    public Scripture(string book , int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }
    public Scripture(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _lastVerse = verse;
    }
    public void Display()
    {
        if (_firstVerse == _lastVerse)
        {
            //If the Scripture has one verse
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}");
        }
        else
        {
            //If the Scripture has more then one verse
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
        }
    }
}