namespace LSP;

public class Sparrow : FlyingBird
{

    public Sparrow(string name) : base(name)
    {

    }


    public override void Fly()
    {
        Console.WriteLine(
            $"{Name} is flying"
        );
    }

}