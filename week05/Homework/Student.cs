public class Student
{
    private string _name;
    private string _topic;

    public Student(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetTopic()
    {
        return _topic;
    }
        public string Summary()
    {
        return $"{_name} - {_topic}";
    }

}