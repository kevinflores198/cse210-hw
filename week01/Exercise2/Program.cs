using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Please insert your grade percentage: ");

        // Defining variables
        int grade = int.Parse(Console.ReadLine());

        // Doing the complete grade with message + letter grade
        if (grade >= 90)
        {
            Console.Write($"Your grade is A");
        }
        else if (grade >= 80)
        {
            Console.Write("Your grade is B");
        }
        else if (grade >= 70)
        {
            Console.Write("Your grade is C");
        }
        else if (grade >= 60)
        {
            Console.Write("Your grade is D");
        }
        else
        {
            Console.Write("Your grade is F");
        }

        if (grade >= 70)
        {
            Console.Write("\nCongratulations! You have passed the course.");
        }
        else
        {
            Console.Write("\nAfortunatelly for this time, you will have to do again the course, Good Luck next time!");
        }
    }
}