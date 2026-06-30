namespace TemplateMethod;


public abstract class Beverage
{

    public void Prepare()
    {
        BoilWater();

        AddIngredient();

        PourInCup();

        AddExtra();
    }



    private void BoilWater()
    {
        Console.WriteLine("Boiling Water");
    }



    private void PourInCup()
    {
        Console.WriteLine("Pouring into Cup");
    }



    protected abstract void AddIngredient();



    protected virtual void AddExtra()
    {

    }

}