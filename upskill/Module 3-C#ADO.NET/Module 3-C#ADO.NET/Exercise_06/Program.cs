// Exercise 6: Loop Through an Array with Different Loop Types
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("--- for loop (skip even) ---");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0) continue;
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine("\n--- foreach loop (stop at 7) ---");
        foreach (int n in numbers)
        {
            if (n == 7) break;
            Console.Write(n + " ");
        }

        Console.WriteLine("\n--- while loop ---");
        int idx = 0;
        while (idx < numbers.Length)
            Console.Write(numbers[idx++] + " ");

        Console.WriteLine("\n--- do-while loop ---");
        int j = 0;
        do { Console.Write(numbers[j++] + " "); } while (j < numbers.Length);
        Console.WriteLine();
    }
}
