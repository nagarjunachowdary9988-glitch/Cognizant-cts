namespace Exception_Handling;

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message)
        : base(message)
    {

    }
}