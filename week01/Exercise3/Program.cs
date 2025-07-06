using System;
using System.Buffers;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("A random number will be generated");

        // Making random number
        Random magicRandomNumber = new Random();

        // Assigning the range
        int magicNumber = magicRandomNumber.Next(1, 100);
        int guessNumber = 0;
        Console.Write("Please Guess the number: ");

        // doing the count of attempts
        int counter = 0;
        
        // Doing do-while loop to keep trying while the number isn't the same
        do
        {
            guessNumber = int.Parse(Console.ReadLine());
            // counter is used after the guessNumber variable to count the times we use this loop.
            counter++;
            if (guessNumber == magicNumber)
            {
                // using a break, if the user guess the number at the begining, the please try again doesn't appear
                break;
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("higher");
            }
            Console.Write("Please try again: ");

        } while (guessNumber != magicNumber);

        Console.WriteLine($"Congrats!!! You guessed the number! This one was: {magicNumber}");
        if (counter == 1)
        {
            Console.WriteLine($"You tried {counter} time.");
        }
        else
        {
            Console.WriteLine($"You tried {counter} times.");
        }
    }
}