
public class Circle : Shape
{
    private double _radius;

    public Circle() { }
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public override double Area()
    {
        double area = 3.14159265359 * GetRadius() * GetRadius();
        return area;
    }

}