namespace DIP;

public class OrderService
{
    private readonly IDatabase database;


    public OrderService(IDatabase database)
    {
        this.database = database;
    }


    public void PlaceOrder()
    {
        database.Connect();

        Console.WriteLine("Order placed successfully");
    }
}