using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Student 1:");
        Student s = new Student("Kevin","C Sharp");
        System.Console.WriteLine(s.Summary());
        System.Console.WriteLine("----------------------------------------");
        System.Console.WriteLine("Student 2:");
        Math m = new Math("Nicolas","Getter and Setter", "5.5","10-12");
        System.Console.WriteLine(m.Summary());
        System.Console.WriteLine(m.HomeworkList());
        System.Console.WriteLine("----------------------------------------");
        System.Console.WriteLine("Student 3:");
        Writing w = new Writing("Kevo", "Java","Programming with classes");
        System.Console.WriteLine(w.Summary());
        System.Console.WriteLine(w.WritingInformation());
        System.Console.WriteLine("----------------------------------------");
    }
}