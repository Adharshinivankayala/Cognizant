// Exercise 30: CRUD Operations using ADO.NET
// NOTE: Requires SQL Server. Replace connection string with your server details.
using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    // Update this connection string to point to your local SQL Server
    const string ConnStr = "Server=localhost;Database=TestDB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main()
    {
        try
        {
            using var conn = new SqlConnection(ConnStr);
            conn.Open();
            Console.WriteLine("Connected to SQL Server.");

            // Create table if not exists
            ExecuteNonQuery(conn, @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Employees' AND xtype='U')
                CREATE TABLE Employees (
                    Id       INT IDENTITY PRIMARY KEY,
                    Name     NVARCHAR(100) NOT NULL,
                    Position NVARCHAR(100),
                    Salary   DECIMAL(10,2)
                )");

            // INSERT
            ExecuteNonQuery(conn, "INSERT INTO Employees (Name, Position, Salary) VALUES ('Alice', 'Developer', 75000)");
            ExecuteNonQuery(conn, "INSERT INTO Employees (Name, Position, Salary) VALUES ('Bob', 'Designer', 65000)");
            Console.WriteLine("Inserted 2 employees.");

            // READ
            Console.WriteLine("\n--- All Employees ---");
            using (var cmd = new SqlCommand("SELECT * FROM Employees", conn))
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                    Console.WriteLine($"  [{reader["Id"]}] {reader["Name"]} | {reader["Position"]} | ${reader["Salary"]}");

            // UPDATE
            ExecuteNonQuery(conn, "UPDATE Employees SET Salary = 80000 WHERE Name = 'Alice'");
            Console.WriteLine("\nUpdated Alice's salary.");

            // READ after update
            Console.WriteLine("\n--- After Update ---");
            using (var cmd = new SqlCommand("SELECT * FROM Employees", conn))
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                    Console.WriteLine($"  [{reader["Id"]}] {reader["Name"]} | {reader["Position"]} | ${reader["Salary"]}");

            // DELETE
            ExecuteNonQuery(conn, "DELETE FROM Employees WHERE Name = 'Bob'");
            Console.WriteLine("\nDeleted Bob.");

            // READ after delete
            Console.WriteLine("\n--- After Delete ---");
            using (var cmd = new SqlCommand("SELECT * FROM Employees", conn))
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                    Console.WriteLine($"  [{reader["Id"]}] {reader["Name"]} | {reader["Position"]} | ${reader["Salary"]}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"DB Error: {ex.Message}");
        }
    }

    static void ExecuteNonQuery(SqlConnection conn, string sql)
    {
        using var cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }
}
