// Exercise 20: LINQ for Filtering and Projection
using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public int    OrderId      { get; set; }
    public string CustomerName { get; set; } = "";
    public double TotalAmount  { get; set; }
}

class Program
{
    static void Main()
    {
        var orders = new List<Order>
        {
            new Order { OrderId=1, CustomerName="Alice", TotalAmount=250.0  },
            new Order { OrderId=2, CustomerName="Bob",   TotalAmount=80.0   },
            new Order { OrderId=3, CustomerName="Charlie",TotalAmount=500.0 },
            new Order { OrderId=4, CustomerName="Diana", TotalAmount=150.0  },
        };

        var highValue = orders
            .Where(o => o.TotalAmount > 100)
            .Select(o => new { o.OrderId, o.CustomerName, o.TotalAmount })
            .OrderByDescending(o => o.TotalAmount);

        Console.WriteLine("Orders > $100:");
        foreach (var o in highValue)
            Console.WriteLine($"  #{o.OrderId} {o.CustomerName}: ${o.TotalAmount}");
    }
}
