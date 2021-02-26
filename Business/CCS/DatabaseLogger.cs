using Business.CCS;
using System;

public class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Verıtabanına loglandı");
    }
}