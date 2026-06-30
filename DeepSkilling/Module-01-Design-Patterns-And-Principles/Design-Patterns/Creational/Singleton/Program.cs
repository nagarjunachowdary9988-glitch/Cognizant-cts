using Singleton;


Logger logger1 = Logger.GetInstance();

Logger logger2 = Logger.GetInstance();


logger1.Log("First log message");

logger2.Log("Second log message");


if(logger1 == logger2)
{
    Console.WriteLine("Both objects are same instance");
}