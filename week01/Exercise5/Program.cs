using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squared = SquareNumber(favoriteNumber);
        DisplayResult(userName, squared);
    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcone to the Program!");
    }

    // Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        System.Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Asks for and returns the user's favorite number (as an integer) 
    static int PromptUserNumber()
    {
        System.Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    // Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    //  Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int squared)
    {
        System.Console.WriteLine($"Brother {userName} the square of your number is {squared}.");
    }
}