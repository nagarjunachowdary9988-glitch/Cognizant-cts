using Proxy;


IImage image =
new ProxyImage("photo.jpg");


Console.WriteLine("First call:");

image.Display();


Console.WriteLine();


Console.WriteLine("Second call:");

image.Display();