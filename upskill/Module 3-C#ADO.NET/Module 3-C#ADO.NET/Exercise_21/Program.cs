// Exercise 21: Pattern Matching with is and switch
using System;

class Program
{
    static void Describe(object obj)
    {
        if (obj is int i)      Console.WriteLine($"Integer: {i}");
        else if (obj is string s) Console.WriteLine($"String of length {s.Length}: \"{s}\"");
        else if (obj is double d) Console.WriteLine($"Double: {d:F2}");
        else                   Console.WriteLine($"Unknown type: {obj.GetType().Name}");
    }

    static string Classify(object obj) => obj switch
    {
        int n when n < 0    => $"Negative int: {n}",
        int n               => $"Positive int: {n}",
        string { Length: 0} => "Empty string",
        string s            => $"Non-empty string: {s}",
        null                => "null value",
        _                   => $"Other: {obj}"
    };

    static void Main()
    {
        object[] items = { 42, -5, "Hello", "", 3.14, null! };
        foreach (var item in items)
        {
            Describe(item);
            Console.WriteLine($"  => {Classify(item)}");
        }
    }
}
