namespace OCP;

public class UPIPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment done using UPI");
    }
}