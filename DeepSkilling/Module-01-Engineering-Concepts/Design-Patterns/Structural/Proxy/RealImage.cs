namespace Proxy;

public class RealImage : IImage
{

    private string filename;


    public RealImage(string filename)
    {
        this.filename = filename;

        LoadImage();
    }


    private void LoadImage()
    {
        Console.WriteLine(
            "Loading image: " + filename
        );
    }


    public void Display()
    {
        Console.WriteLine(
            "Displaying image: " + filename
        );
    }

}