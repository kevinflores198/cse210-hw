public class Comment
{
    public string _text;
    public string _commentatorName;
    public void DisplayComment()
    {
        System.Console.WriteLine($"Comment by {_commentatorName}: {_text}");
    }
}