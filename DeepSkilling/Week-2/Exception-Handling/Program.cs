using Exception_Handling;


try
{
    Console.Write("Enter age: ");

    int age = Convert.ToInt32(Console.ReadLine());


    if(age < 18)
    {
        throw new InvalidAgeException(
            "Age should be 18 or above"
        );
    }


    Console.WriteLine("Eligible");

}

catch(InvalidAgeException ex)
{
    Console.WriteLine(ex.Message);
}


catch(Exception ex)
{
    Console.WriteLine(
        "Error: " + ex.Message
    );
}


finally
{
    Console.WriteLine("Program completed");
}