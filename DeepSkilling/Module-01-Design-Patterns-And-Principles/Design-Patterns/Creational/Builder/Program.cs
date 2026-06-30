using Builder;


Computer computer =
new ComputerBuilder()

.SetCPU("Intel i7")

.SetRAM("16GB")

.SetStorage("512GB SSD")

.Build();


computer.Display();