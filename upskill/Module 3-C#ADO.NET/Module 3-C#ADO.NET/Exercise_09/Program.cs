// Exercise 9: Local Functions
using System;

class Program
{
    static long CalculateFactorial(int n)
    {
        long LocalFactorial(int x) => x <= 1 ? 1 : x * LocalFactorial(x - 1);
        return LocalFactorial(n);
    }

    static void Main()
    {
        for (int i = 0; i <= 10; i++)
            Console.WriteLine($"{i}! = {CalculateFactorial(i)}");
    }
}
