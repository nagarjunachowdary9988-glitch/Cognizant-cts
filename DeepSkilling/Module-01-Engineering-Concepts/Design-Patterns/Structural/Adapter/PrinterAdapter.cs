namespace Adapter;

public class PrinterAdapter : IPrinter
{

    private OldPrinter oldPrinter;


    public PrinterAdapter()
    {
        oldPrinter = new OldPrinter();
    }


    public void Print()
    {
        oldPrinter.PrintDocument();
    }

}