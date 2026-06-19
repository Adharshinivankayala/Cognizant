// Exercise 28: Log with System.Diagnostics.Trace
using System;
using System.Diagnostics;

class Logger
{
    public Logger(string logFile)
    {
        Trace.Listeners.Add(new TextWriterTraceListener(logFile, "fileListener"));
        Trace.Listeners.Add(new ConsoleTraceListener());
        Trace.AutoFlush = true;
    }

    public void Log(string message) =>
        Trace.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
}

class Program
{
    static void Main()
    {
        var logger = new Logger("app.log");
        logger.Log("Application started.");
        logger.Log("Processing data...");
        logger.Log("Application finished.");
        Console.WriteLine("Log written to app.log and console.");
    }
}
