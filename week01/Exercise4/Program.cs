using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished:");

        // We create the list
        List<int> numbers = new List<int>();

        // Variable to use the number that will be into the list
        int num;

        // do-while loop until the number is 0
        do
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            // We use .add to add all numbers entered
            numbers.Add(num);
        } while (num != 0);
        Console.WriteLine("Complete list: ");

        // a for loop to see all numbers added on the list.
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write($"{numbers[i]} ");
            numbers.Remove(0);
        }

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");

    }
}