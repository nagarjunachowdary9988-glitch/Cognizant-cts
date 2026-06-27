namespace AbstractFactory;

public class WindowsButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Windows Button");
    }
}