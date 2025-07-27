using System.Reflection;
using System.Security.Cryptography.X509Certificates;

public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments = new List<Comment>();
    public void DisplayVideo()
    {
        System.Console.WriteLine($"Video name: {_title} | Author: {_author} | Time: {_length}\n");
        System.Console.WriteLine("Comments:");
        foreach (Comment com in _comments)
        {
            com.DisplayComment();
        }
    }
    public void AddComment(Comment comment)
    {
        comment._text = Console.ReadLine();
        _comments.Add(comment);
    }
    public int NumberOfComments()
    {
        return _comments.Count;
    }
}