using System;
using System.ComponentModel;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Please add your name: ");
        string name = Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine($"Welcome to Mindfulness Program! {name}");
        int answer = 0;
        while (answer != 2)
        {
            System.Console.WriteLine("Menu options:");
            System.Console.WriteLine("1. Start breating activity.\n2. Start reflecting activity.\n3. Start listing activity.\n4. Exit.");
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
                    al.DisplayStartingMessage("Listing");
                    al.Run();
                    al.DisplayEndingMessage(name);
                    break;
                case 4:
                    break;
                default:
                    System.Console.WriteLine("Invalid option, choice must be between 1-4.");
                    break;
            }
            System.Console.WriteLine("Do you want to run this program again?\n1. Yes\n2. Exit");
            answer = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Thank you for using our program! See you later!");
    }
}