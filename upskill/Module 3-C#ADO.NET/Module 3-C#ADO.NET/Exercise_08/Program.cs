// Exercise 8: ref, out, and in Parameters
using System;

class Program
{
    static void DoubleIt(ref int x)          { x *= 2; }
    static void GetMinMax(int[] arr, out int min, out int max)
    {
        min = arr[0]; max = arr[0];
        foreach (var n in arr) { if (n < min) min = n; if (n > max) max = n; }
    }
    static void PrintReadOnly(in int value)  { Console.WriteLine($"in value: {value}"); }

    static void Main()
    {
        int val = 5;
        Console.WriteLine($"Before ref: {val}");
        DoubleIt(ref val);
        Console.WriteLine($"After  ref: {val}");

        int[] nums = { 3, 1, 7, 2, 9 };
        GetMinMax(nums, out int min, out int max);
        Console.WriteLine($"out -> Min={min}, Max={max}");

        PrintReadOnly(in val);
    }
}
