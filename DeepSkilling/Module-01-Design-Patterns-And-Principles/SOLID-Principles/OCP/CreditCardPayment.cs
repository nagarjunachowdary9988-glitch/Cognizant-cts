namespace OCP;

public class CreditCardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment done using Credit Card");
    }
}