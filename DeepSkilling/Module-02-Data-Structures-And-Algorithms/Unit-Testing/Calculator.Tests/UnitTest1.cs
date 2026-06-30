using Xunit;
using Calculator;


public class UnitTest1
{

    [Fact]
    public void Add_Test()
    {

        CalculatorService calculator =
            new CalculatorService();


        int result =
            calculator.Add(10,20);


        Assert.Equal(30,result);

    }



    [Fact]
    public void Multiply_Test()
    {

        CalculatorService calculator =
            new CalculatorService();


        int result =
            calculator.Multiply(5,5);


        Assert.Equal(25,result);

    }

}