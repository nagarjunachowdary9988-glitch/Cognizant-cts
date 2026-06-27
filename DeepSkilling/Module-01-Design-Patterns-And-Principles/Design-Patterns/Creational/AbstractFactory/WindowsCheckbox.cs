namespace AbstractFactory;

public class WindowsCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Windows Checkbox");
    }
}