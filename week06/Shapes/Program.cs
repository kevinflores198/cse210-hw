using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s = new Square(10,"Red");
        shapes.Add(s);

        Rectangle r = new Rectangle(20,15,"Blue");
        shapes.Add(r);

        Circle c = new Circle(5,"Brown");
        shapes.Add(c);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();
            double area = i.Area();
            System.Console.WriteLine($"-----\nShape color: {color}\nArea: {area}");
        }
    }
}