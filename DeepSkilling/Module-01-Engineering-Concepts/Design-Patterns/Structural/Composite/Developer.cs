namespace Composite;

public class Developer : IEmployee
{

    private string name;


    public Developer(string name)
    {
        this.name = name;
    }


    public void ShowDetails()
    {
        Console.WriteLine(
            "Developer: " + name
        );
    }

}