using System;
using System.Collections;
using System.Xml.Linq;

public class JournalEntry
{
      
    private string prompt;
    private string response;
    private DateTime entryDate;

    public JournalEntry(string prompt, string response)
    {
        this.prompt = prompt;
        this.response = response;
        entryDate = DateTime.Now;
    }

    public DateTime Date { get; internal set; }

    public override string ToString()
    {
        return $"Date: {entryDate}\nPrompt: {prompt}\nResponse: {response}\n";
    }
}