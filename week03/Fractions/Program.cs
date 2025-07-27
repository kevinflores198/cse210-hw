using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // using no parameters as the number is gonna return 1, first constructor used.
        Fraction fraction_1 = new Fraction();
        System.Console.WriteLine(fraction_1.GetDecimalValue());
        System.Console.WriteLine(fraction_1.GetFractionString());

        // using parameter with just one number, reeplace the wholeNumber.
        Fraction fraction_2 = new Fraction(5);
        System.Console.WriteLine(fraction_2.GetDecimalValue());
        System.Console.WriteLine(fraction_2.GetFractionString());

        // using parameter with just two numbers, reeplace the bottonNumber and topNumber.
        Fraction fraction_3 = new Fraction(6, 4);
        System.Console.WriteLine(fraction_3.GetDecimalValue());
        System.Console.WriteLine(fraction_3.GetFractionString());

        // using parameter with just two numbers, reeplace the bottonNumber and topNumber.
        Fraction fraction_4 = new Fraction(1, 3);
        System.Console.WriteLine(fraction_4.GetDecimalValue());
        System.Console.WriteLine(fraction_4.GetFractionString());
    }
}