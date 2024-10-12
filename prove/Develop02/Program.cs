using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
         Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    journal.CreateEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter filename to save the journal: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case 4:
                    Console.Write("Enter filename to load the journal from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }
        }                 
    }    
}