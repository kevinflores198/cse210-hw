using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Menu options:");
        string name = "Kevin";
        System.Console.WriteLine("1. Start breating activity.\n2. Start reflecting activity.\n3. Start listing activity.\n4. Salir.");
        System.Console.WriteLine("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Activity_Breathing ab = new Activity_Breathing();
                ab.DisplayStartingMessage("Breathing");
                ab.Run();
                ab.DisplayEndingMessage(name);
                break;
            case 2:
                Activity_Reflecting ar = new Activity_Reflecting();
                ar.DisplayStartingMessage("Reflecting");
                ar.Run();
                ar.DisplayEndingMessage(name);
                break;
            case 3:
                Activity_Listing al = new Activity_Listing();
                break;
            default:
                System.Console.WriteLine("Invalid option, choice must be between 1-4.");
                break;
        }

    }
}