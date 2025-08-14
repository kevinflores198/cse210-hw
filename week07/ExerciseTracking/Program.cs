using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> actList = new List<Activity>();
        int report = 0;
        do
        {
            {
                System.Console.WriteLine("Please enter the activity you did:");
                System.Console.WriteLine("1. Running\n2. Swimming\n3. Bicycle");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Activity_Running ar = new Activity_Running();
                        System.Console.WriteLine("Please enter the distance ran: (KM)");
                        ar.SetDistance(double.Parse(Console.ReadLine()));
                        System.Console.WriteLine("How many minutes you ran?");
                        ar.SetMinutes(int.Parse(Console.ReadLine()));
                        actList.Add(ar);
                        break;
                    case 2:
                        Activity_Swimming asw = new Activity_Swimming();
                        System.Console.WriteLine("Please enter number of laps: ");
                        asw.SetLaps(int.Parse(Console.ReadLine()));
                        System.Console.WriteLine("How many minutes you swap?");
                        asw.SetMinutes(int.Parse(Console.ReadLine()));
                        actList.Add(asw);
                        break;
                    case 3:
                        Activity_bicycles ab = new Activity_bicycles();
                        System.Console.WriteLine("Please enter speed you ride the bike: (KMH)");
                        ab.SetSpeed(double.Parse(Console.ReadLine()));
                        System.Console.WriteLine("How many minutes you ran?");
                        ab.SetMinutes(int.Parse(Console.ReadLine()));
                        actList.Add(ab);
                        break;
                    default:
                        System.Console.WriteLine("Please try again using 1,2 or 3.");
                        break;
                }
            }
            System.Console.WriteLine("Do you want to report another activity? 1. Yes 2. No");
            report = int.Parse(Console.ReadLine());
        } while (report != 2);
        System.Console.WriteLine("Thanks for using this App! There is your activity today: ");
        foreach (Activity a in actList)
        {
            System.Console.WriteLine(a.GetSummary());
        }
    }

}