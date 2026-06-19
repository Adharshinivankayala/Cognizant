// Exercise 26: Race Conditions with Multi-threading
using System;
using System.Threading;

class Program
{
    static int counter = 0;
    static readonly object _lock = new object();

    static void Increment(int iterations)
    {
        for (int i = 0; i < iterations; i++)
            lock (_lock) { counter++; }
    }

    static void Main()
    {
        int n = 10000;
        var t1 = new Thread(() => Increment(n));
        var t2 = new Thread(() => Increment(n));
        var t3 = new Thread(() => Increment(n));

        t1.Start(); t2.Start(); t3.Start();
        t1.Join();  t2.Join();  t3.Join();

        Console.WriteLine($"Expected: {3 * n}, Got: {counter}");
        Console.WriteLine(counter == 3 * n ? "No race condition (lock worked)." : "Race condition occurred!");
    }
}
