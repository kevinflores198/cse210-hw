using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Please enter the activity you did:");
        System.Console.WriteLine("1. Running\n2. Swimming\n3. Bicycle");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Activity ar = new Activity_Running();
                ar.GetDistance();
                ar.GetSummary();
                break;
            case 2:
                Activity asw = new Activity_Swimming();
                asw.GetSpeed();
                asw.GetSummary();
                break;
            case 3:
                Activity ab = new Activity_bicycles();
                ab.GetPace();
                ab.GetSummary();
                break;
            default:
                System.Console.WriteLine("Please try again using 1,2 or 3.");
                break;
        }
    }
}