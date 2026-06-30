namespace Generics;


public class Box<T>
{
    private T value;


    public void SetValue(T value)
    {
        this.value = value;
    }


    public T GetValue()
    {
        return value;
    }
}