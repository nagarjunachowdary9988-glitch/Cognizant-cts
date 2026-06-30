using TemplateMethod;


class Tea : Beverage
{
    protected override void AddIngredient()
    {
        Console.WriteLine("Adding Tea Powder");
    }


    protected override void AddExtra()
    {
        Console.WriteLine("Adding Sugar");
    }
}



class Coffee : Beverage
{
    protected override void AddIngredient()
    {
        Console.WriteLine("Adding Coffee Powder");
    }
}



class Program
{
    static void Main()
    {

        Console.WriteLine("Making Tea");

        Beverage tea = new Tea();

        tea.Prepare();



        Console.WriteLine();



        Console.WriteLine("Making Coffee");


        Beverage coffee = new Coffee();

        coffee.Prepare();

    }
}