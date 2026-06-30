namespace DIP;

public class MongoDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connected to Mongo Database");
    }
}