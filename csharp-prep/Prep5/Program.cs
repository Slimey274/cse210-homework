using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string user_name = PromptUserName();
        int user_number = UserFavoriteNumber();

        int square_number = NumberSquared(user_number);

        DisplayResult(user_name, square_number);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter in yor name? ");
        string name = Console.ReadLine();

        return name;
    }
    static int UserFavoriteNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int NumberSquared(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, The square of your number is {square}.");
    }
}
        