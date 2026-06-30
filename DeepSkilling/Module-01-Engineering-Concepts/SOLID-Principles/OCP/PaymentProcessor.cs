namespace OCP;

public class PaymentProcessor
{
    public void Process(IPayment payment)
    {
        payment.Pay();
    }
}