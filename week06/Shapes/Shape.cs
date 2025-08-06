public abstract class Shape
{
    private string _color;
    public Shape() { }
    public Shape(string color)
    {
        _color = color;
    }
    public void SetColor(string color)
    {
        color = _color;
    }
    public string GetColor()
    {
        return _color;
    }
    public abstract double Area();
}