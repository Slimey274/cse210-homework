using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

public class Word
{
    public string _word;
    public bool _revealed;

    public Word(string word)
    {
        _word = word;
        _revealed = true;
    }
    public void Display()
    {
        if (_revealed)
        {
            Console.WriteLine(_word);
        }
        else
        {
        Console.WriteLine(new string('_', _word.Length));
        }
    }
    public void Hide()
    {
        _revealed = false;
    }
    public void IsRevealed(bool revealed)
    {
        _revealed = revealed;
    }
}