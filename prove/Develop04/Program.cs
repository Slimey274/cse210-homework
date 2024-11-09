using System;

class Program
{
    static void Main(string[] args)
    {
        /* Test for Breathing.cs to see if it works */
        // Breathing breathing = new Breathing();
        // breathing.BreathingAtivity("Relaxing Breathing Exercise", "Prepare to breathe...");
        Listing listing = new Listing();
        Reflecting reflecting = new Reflecting();
        Breathing breathing = new Breathing();
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Get a listing prompt");
            Console.WriteLine("2. Get a reflecting prompt");
            Console.WriteLine("3. Start breathing activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": listing.GetPrompt();
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey(); 
                    break; 
                case "2":
                    reflecting.GetPrompt();
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey(); 
                    break; 
                case "3":
                    breathing.BreathingActivity(); Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                    break;
                case "4": exit = true;
                    break;
                default: Console.WriteLine("Invalid choice. Try again.");
                break;
            }
        }
    }
}