// Exercise 14: Inheritance and Method Overriding
using System;

class Shape
{
    public virtual void Draw() => Console.WriteLine("Drawing a Shape");
}

class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a Circle ◯");
}

class Rectangle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a Rectangle □");
}

class Program
{
    static void Main()
    {
        Shape[] shapes = { new Shape(), new Circle(), new Rectangle() };
        foreach (var s in shapes) s.Draw();
    }
}
