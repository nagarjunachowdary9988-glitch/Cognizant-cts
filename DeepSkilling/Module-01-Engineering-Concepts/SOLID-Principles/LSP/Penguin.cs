namespace LSP;

public class Penguin : Bird
{

    public Penguin(string name) : base(name)
    {

    }


    public void Swim()
    {
        Console.WriteLine(
            $"{Name} is swimming"
        );
    }

}