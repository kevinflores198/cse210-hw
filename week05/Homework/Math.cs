public class Math : Student
{
    private string _textBookSection;
    private string _problem;
    public Math(string name, string topic, string textBookSection, string problem)
    : base(name, topic)
    {
        _textBookSection = textBookSection;
        _problem = problem;
    }

    public string GetTextBookSection()
    {
        return _textBookSection;
    }
    public string Getproblem()
    {
        return _problem;
    }
    public string HomeworkList()
    {
        return $"Section {_textBookSection} - Problem {_problem}";
    }

}