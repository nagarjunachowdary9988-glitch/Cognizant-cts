using Microsoft.Extensions.Logging;



using var loggerFactory =
    LoggerFactory.Create(builder =>
    {
        builder
        .AddConsole();
    });



ILogger logger =
    loggerFactory.CreateLogger<Program>();



logger.LogInformation(
    "Application Started"
);



try
{

    int a = 10;

    int b = 0;


    int result = a / b;


    Console.WriteLine(result);

}


catch(Exception ex)
{

    logger.LogError(
        ex,
        "Error occurred while dividing numbers"
    );

}



logger.LogInformation(
    "Application Ended"
);