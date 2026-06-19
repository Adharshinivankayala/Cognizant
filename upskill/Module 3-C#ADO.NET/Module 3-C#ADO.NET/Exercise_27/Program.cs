// Exercise 27: Simulate and Resolve a Deadlock
using System;
using System.Threading;

class Program
{
    static readonly object lockA = new object();
    static readonly object lockB = new object();

    static void Thread1()
    {
        if (Monitor.TryEnter(lockA, 500))
        {
            try
            {
                Console.WriteLine("T1 acquired lockA");
                Thread.Sleep(100);
                if (Monitor.TryEnter(lockB, 500))
                {
                    try { Console.WriteLine("T1 acquired lockB — task done"); }
                    finally { Monitor.Exit(lockB); }
                }
                else Console.WriteLine("T1 could not acquire lockB (deadlock avoided)");
            }
            finally { Monitor.Exit(lockA); }
        }
        else Console.WriteLine("T1 could not acquire lockA");
    }

    static void Thread2()
    {
        if (Monitor.TryEnter(lockB, 500))
        {
            try
            {
                Console.WriteLine("T2 acquired lockB");
                Thread.Sleep(100);
                if (Monitor.TryEnter(lockA, 500))
                {
                    try { Console.WriteLine("T2 acquired lockA — task done"); }
                    finally { Monitor.Exit(lockA); }
                }
                else Console.WriteLine("T2 could not acquire lockA (deadlock avoided)");
            }
            finally { Monitor.Exit(lockB); }
        }
        else Console.WriteLine("T2 could not acquire lockB");
    }

    static void Main()
    {
        var t1 = new Thread(Thread1);
        var t2 = new Thread(Thread2);
        t1.Start(); t2.Start();
        t1.Join();  t2.Join();
        Console.WriteLine("Done — no indefinite deadlock.");
    }
}
