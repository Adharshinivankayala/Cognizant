Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();

logger1.Log("Application Started");
logger2.Log("Logging Information");

if (logger1 == logger2)
{
    Console.WriteLine("Only one instance of Logger is created.");
}
else
{
    Console.WriteLine("Multiple instances are created.");
}