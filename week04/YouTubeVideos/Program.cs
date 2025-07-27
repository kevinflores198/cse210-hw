using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        int counter = 0;
        List<Video> _videos = new List<Video>();
        do
        {
            Video video1 = new Video();

            System.Console.WriteLine("Please add name's author: ");
            video1._author = Console.ReadLine();
            System.Console.WriteLine("Please add Title of video: ");
            video1._title = Console.ReadLine();
            System.Console.WriteLine("Please add length of video in seconds: ");
            video1._length = double.Parse(Console.ReadLine());
            _videos.Add(video1);
            do
            {
                Comment comment = new Comment();
                System.Console.WriteLine("What is your name? ");
                comment._commentatorName = Console.ReadLine();
                System.Console.WriteLine("What do you want to comment?");
                video1.AddComment(comment);
                System.Console.WriteLine("Do you want to comment anything else? 1: Yes / Other number: No");
                answer = int.Parse(Console.ReadLine());
            } while (answer == 1);
            counter++;
        } while (counter != 2);

        foreach (Video v in _videos)
        {
            v.DisplayVideo();
            System.Console.WriteLine($"Total comments:{v.NumberOfComments()}");
        }
    }
}