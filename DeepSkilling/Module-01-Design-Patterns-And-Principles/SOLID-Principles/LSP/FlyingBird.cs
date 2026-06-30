namespace LSP;

public abstract class FlyingBird : Bird
{
    public FlyingBird(string name) : base(name)
    {

    }

    public abstract void Fly();
}