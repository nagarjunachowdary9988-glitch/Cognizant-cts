using SRP;


Employee emp = new Employee(
    1,
    "Nagarjuna",
    "AIML"
);


EmployeeRepository repository = 
    new EmployeeRepository();


EmployeeReport report = 
    new EmployeeReport();


repository.Save(emp);

report.Generate(emp);