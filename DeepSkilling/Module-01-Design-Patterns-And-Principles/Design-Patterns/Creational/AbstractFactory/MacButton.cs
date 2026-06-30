namespace AbstractFactory;

public class MacButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Mac Button");
    }
}