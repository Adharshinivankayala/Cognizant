// Exercise 5: Conditional Logic for Grade Calculation
using System;

class Program
{
    static string GetGrade(int score) => score switch
    {
        >= 90 => "A",
        >= 80 => "B",
        >= 70 => "C",
        >= 60 => "D",
        _      => "F"
    };

    static void Main()
    {
        Console.Write("Enter your score: ");
        int score = int.Parse(Console.ReadLine() ?? "0");

        if      (score >= 90) Console.WriteLine("if/else Grade: A");
        else if (score >= 80) Console.WriteLine("if/else Grade: B");
        else if (score >= 70) Console.WriteLine("if/else Grade: C");
        else if (score >= 60) Console.WriteLine("if/else Grade: D");
        else                  Console.WriteLine("if/else Grade: F");

        Console.WriteLine($"switch Grade : {GetGrade(score)}");
    }
}
