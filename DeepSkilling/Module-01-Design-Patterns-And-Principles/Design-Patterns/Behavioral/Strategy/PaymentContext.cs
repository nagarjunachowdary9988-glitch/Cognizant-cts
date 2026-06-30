namespace Strategy;

public class PaymentContext
{

    private IPaymentStrategy strategy;


    public void SetStrategy(IPaymentStrategy strategy)
    {
        this.strategy = strategy;
    }


    public void MakePayment(double amount)
    {
        strategy.Pay(amount);
    }

}