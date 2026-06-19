// Exercise 18: required Modifier in C# 12
using System;

class Student
{
    public required string Name   { get; set; }
    public required int    RollNo { get; set; }
    public string          Grade  { get; set; } = "N/A";
}

class Program
{
    static void Main()
    {
        // This compiles fine — all required properties are set
        var s = new Student { Name = "Ravi", RollNo = 101, Grade = "A" };
        Console.WriteLine($"Student: {s.Name}, Roll: {s.RollNo}, Grade: {s.Grade}");

        // Uncommenting the line below would cause a compile-time error:
        // var s2 = new Student { Name = "Priya" }; // CS9035: Required member 'RollNo' not set
    }
}
