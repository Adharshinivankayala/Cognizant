// Exercise 12: Auto-Properties and Backing Fields
using System;

class Product
{
    public string Name { get; set; } = "";
    private double _price;
    public double Price
    {
        get => _price;
        set => _price = value < 0 ? throw new ArgumentException("Price cannot be negative.") : value;
    }
}

class Program
{
    static void Main()
    {
        var p = new Product { Name = "Laptop", Price = 999.99 };
        Console.WriteLine($"Name: {p.Name}, Price: {p.Price:C}");
        try   { p.Price = -50; }
        catch (ArgumentException ex) { Console.WriteLine($"Validation error: {ex.Message}"); }
    }
}
