using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Jhon", 3, 15);
        Scripture scripture = new Scripture(reference, "\nthat whosoever believeth in him should not perish, but have eternal life");

        System.Console.WriteLine("Welcome to Scripture Memorizer program!");
        while (!scripture.IsAllHidden())
        {
            Console.Clear();
            System.Console.WriteLine(scripture.GetDisplay());
            System.Console.WriteLine("You will use 'enter key' or type quit.");
            string quit = Console.ReadLine();
            if (quit == "quit")
            {
                break;
            }
            scripture.HideRandom(1);
        }
        System.Console.WriteLine("Thanks for practice!");
        Console.Clear();
        Console.WriteLine(scripture.GetDisplay());

    }
}