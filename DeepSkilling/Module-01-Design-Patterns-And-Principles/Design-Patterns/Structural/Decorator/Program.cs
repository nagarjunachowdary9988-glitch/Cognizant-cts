using Decorator;


ICoffee coffee =
new SimpleCoffee();


coffee =
new MilkDecorator(coffee);


Console.WriteLine(
coffee.GetDescription()
);


Console.WriteLine(
"Cost: " + coffee.GetCost()
);