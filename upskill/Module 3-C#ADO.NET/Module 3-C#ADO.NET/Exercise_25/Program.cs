// Exercise 25: FileStream and MemoryStream
using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // Write a file first
        File.WriteAllText("sample.txt", "Hello from FileStream!\nLine 2.\nLine 3.");

        // Read using FileStream
        Console.WriteLine("--- FileStream read ---");
        using (var fs = new FileStream("sample.txt", FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            Console.WriteLine(Encoding.UTF8.GetString(buffer));
        }

        // MemoryStream write
        Console.WriteLine("--- MemoryStream write ---");
        using (var ms = new MemoryStream())
        {
            byte[] data = Encoding.UTF8.GetBytes("MemoryStream data example.");
            ms.Write(data, 0, data.Length);
            Console.WriteLine($"Bytes written: {ms.Length}");
            ms.Position = 0;
            using var reader = new StreamReader(ms);
            Console.WriteLine("Content: " + reader.ReadToEnd());
        }
    }
}
