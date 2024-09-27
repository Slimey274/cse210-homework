using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        // This was for part one and two
        // Console.WriteLine("What is the magic number? 6");
        // int magicNumber = int.Parse(Console.ReadLine())

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {   
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess) 
                {
                    Console.WriteLine("Higer");
                }
            else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
            else
                {
                    Console.WriteLine("You guessed it!");
                }
        }
    }  
}