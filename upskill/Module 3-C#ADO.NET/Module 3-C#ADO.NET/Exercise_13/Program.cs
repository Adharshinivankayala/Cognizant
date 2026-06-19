// Exercise 13: Records with init Properties
using System;

record Employee
{
    public required string Name       { get; init; }
    public required string Department { get; init; }
    public required double Salary     { get; init; }
}

class Program
{
    static void Main()
    {
        var emp1 = new Employee { Name = "Alice", Department = "IT", Salary = 75000 };
        Console.WriteLine($"Original : {emp1}");

        var emp2 = emp1 with { Salary = 85000 };
        Console.WriteLine($"Modified : {emp2}");
        Console.WriteLine($"Original unchanged: {emp1}");
    }
}
