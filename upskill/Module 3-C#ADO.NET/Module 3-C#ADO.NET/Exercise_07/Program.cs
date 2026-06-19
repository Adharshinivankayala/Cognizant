// Exercise 7: Method Overloading
using System;

class Calculator
{
    public static int    CalculateTotal(int a, int b)              => a + b;
    public static double CalculateTotal(double a, double b)        => a + b;
    public static double CalculateTotal(double a, double b, double c) => a + b + c;
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"int    + int    = {Calculator.CalculateTotal(3, 4)}");
        Console.WriteLine($"double + double = {Calculator.CalculateTotal(3.5, 4.5)}");
        Console.WriteLine($"3 doubles       = {Calculator.CalculateTotal(1.1, 2.2, 3.3)}");
    }
}
