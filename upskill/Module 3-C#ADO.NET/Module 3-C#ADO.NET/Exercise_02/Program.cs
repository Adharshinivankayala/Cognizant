// Exercise 2: Explore Value vs Reference Types
using System;

class MyData
{
    public int Value { get; set; }
}

class Program
{
    static void ModifyValue(int x) { x = 100; }
    static void ModifyReference(MyData obj) { obj.Value = 100; }

    static void Main()
    {
        int a = 10;
        Console.WriteLine($"Before ModifyValue: a = {a}");
        ModifyValue(a);
        Console.WriteLine($"After ModifyValue:  a = {a}");  // unchanged

        MyData data = new MyData { Value = 10 };
        Console.WriteLine($"Before ModifyReference: data.Value = {data.Value}");
        ModifyReference(data);
        Console.WriteLine($"After ModifyReference:  data.Value = {data.Value}");  // changed
    }
}
