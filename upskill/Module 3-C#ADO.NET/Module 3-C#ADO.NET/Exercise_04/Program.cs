// Exercise 4: Type Inference with var and new()
using System;

class Box { public string Label { get; set; } = "Default"; }

class Program
{
    static void Main()
    {
        var number    = 42;
        var text      = "Hello";
        var box       = new Box { Label = "TypeInference" };
        Box box2      = new() { Label = "TargetTyped" };

        Console.WriteLine($"number : {number.GetType().Name} = {number}");
        Console.WriteLine($"text   : {text.GetType().Name} = {text}");
        Console.WriteLine($"box    : {box.GetType().Name}  = {box.Label}");
        Console.WriteLine($"box2   : {box2.GetType().Name} = {box2.Label}");
    }
}
