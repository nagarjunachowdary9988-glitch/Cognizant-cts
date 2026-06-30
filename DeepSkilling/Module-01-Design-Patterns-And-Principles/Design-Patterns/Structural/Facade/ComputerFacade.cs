namespace Facade;

public class ComputerFacade
{

    private CPU cpu;
    private Memory memory;
    private HardDrive hardDrive;


    public ComputerFacade()
    {
        cpu = new CPU();
        memory = new Memory();
        hardDrive = new HardDrive();
    }


    public void StartComputer()
    {
        cpu.Start();

        memory.Load();

        hardDrive.Read();

        Console.WriteLine("Computer Started Successfully");
    }

}