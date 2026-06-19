// Exercise 10: OOP Basics with Constructors
using System;

class Car
{
    public string Make  { get; }
    public string Model { get; }
    public int    Year  { get; }

    public Car() { Make = "Unknown"; Model = "Unknown"; Year = 2000; }
    public Car(string make, string model, int year) { Make = make; Model = model; Year = year; }

    public override string ToString() => $"{Year} {Make} {Model}";
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        Car car2 = new Car("Toyota", "Camry", 2024);
        Console.WriteLine($"Car 1: {car1}");
        Console.WriteLine($"Car 2: {car2}");
    }
}
