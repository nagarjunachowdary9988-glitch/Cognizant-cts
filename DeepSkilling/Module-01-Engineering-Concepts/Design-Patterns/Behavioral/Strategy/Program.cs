using Strategy;


PaymentContext context =
new PaymentContext();


context.SetStrategy(
    new CreditCardPayment()
);


context.MakePayment(500);



context.SetStrategy(
    new UPIPayment()
);


context.MakePayment(300);