using OCP;

PaymentProcessor processor = new PaymentProcessor();

IPayment credit = new CreditCardPayment();

IPayment upi = new UPIPayment();

processor.Process(credit);

processor.Process(upi);