namespace Proxy;

public class ProxyImage : IImage
{

    private RealImage realImage;

    private string filename;


    public ProxyImage(string filename)
    {
        this.filename = filename;
    }


    public void Display()
    {

        if(realImage == null)
        {
            realImage = new RealImage(filename);
        }


        realImage.Display();

    }

}