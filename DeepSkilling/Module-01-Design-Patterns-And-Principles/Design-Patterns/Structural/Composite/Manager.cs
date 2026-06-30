namespace Composite;

public class Manager : IEmployee
{

    private string name;

    private List<IEmployee> employees =
        new List<IEmployee>();


    public Manager(string name)
    {
        this.name = name;
    }


    public void AddEmployee(IEmployee employee)
    {
        employees.Add(employee);
    }


    public void ShowDetails()
    {
        Console.WriteLine(
            "Manager: " + name
        );


        foreach(var employee in employees)
        {
            employee.ShowDetails();
        }
    }

}