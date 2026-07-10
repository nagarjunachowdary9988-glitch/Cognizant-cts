USE CTS_Training;
GO

-- Create Source Table
CREATE TABLE Employee_New
(
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2)
);
GO

-- Insert New Data
INSERT INTO Employee_New VALUES
(101,'Nagarjuna','AIML',80000),
(105,'Sneha','HR',45000),
(106,'Arjun','Finance',60000);
GO

-- MERGE Statement
MERGE Employee AS Target
USING Employee_New AS Source
ON Target.EmpId = Source.EmpId

WHEN MATCHED THEN
    UPDATE SET
        Target.EmpName = Source.EmpName,
        Target.Department = Source.Department,
        Target.Salary = Source.Salary

WHEN NOT MATCHED THEN
    INSERT (EmpId, EmpName, Department, Salary)
    VALUES (Source.EmpId, Source.EmpName, Source.Department, Source.Salary);

GO

-- Display Final Table
SELECT * FROM Employee;
GO