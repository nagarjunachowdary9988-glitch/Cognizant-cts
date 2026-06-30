using Composite;


Developer dev1 =
new Developer("Nagarjuna");


Developer dev2 =
new Developer("Alex");


Manager manager =
new Manager("Team Lead");


manager.AddEmployee(dev1);

manager.AddEmployee(dev2);


manager.ShowDetails();