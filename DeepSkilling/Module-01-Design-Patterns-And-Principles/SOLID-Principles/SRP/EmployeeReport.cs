namespace SRP;

public class EmployeeReport
{
    public void Generate(Employee employee)
    {
        Console.WriteLine(
            $"Employee Report: {employee.Name}"
        );
    }
}