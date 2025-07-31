public class Writing : Student
{
    private string _assignamentTitle;
    public Writing(string name, string topic, string assignamentTitle)
    : base(name, topic)
    {
        _assignamentTitle = assignamentTitle;
    }
    public string WritingInformation()
    {

        return $"{_assignamentTitle} by {base.GetName()}";
    }
}