namespace Builder;

public class ComputerBuilder
{

    private Computer computer;


    public ComputerBuilder()
    {
        computer = new Computer();
    }


    public ComputerBuilder SetCPU(string cpu)
    {
        computer.CPU = cpu;

        return this;
    }


    public ComputerBuilder SetRAM(string ram)
    {
        computer.RAM = ram;

        return this;
    }


    public ComputerBuilder SetStorage(string storage)
    {
        computer.Storage = storage;

        return this;
    }


    public Computer Build()
    {
        return computer;
    }

}