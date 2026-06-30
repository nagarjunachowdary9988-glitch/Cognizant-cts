namespace DIP;

public class MySQLDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connected to MySQL Database");
    }
}