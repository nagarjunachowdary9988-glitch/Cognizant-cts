// Delegate declaration

delegate void MessageDelegate(string message);



class Notification
{

    public void SendEmail(string message)
    {
        Console.WriteLine(
            "Email: " + message
        );
    }



    public void SendSMS(string message)
    {
        Console.WriteLine(
            "SMS: " + message
        );
    }

}



class Program
{

    static void Main()
    {

        Notification notification =
            new Notification();



        MessageDelegate notify;



        notify = notification.SendEmail;

        notify("Meeting at 10 AM");



        notify += notification.SendSMS;

        notify("Your OTP is 1234");

    }

}