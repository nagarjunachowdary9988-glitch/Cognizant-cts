USE CTS_Training;
GO

IF OBJECT_ID('Employee', 'U') IS NOT NULL
    DROP TABLE Employee;
GO

CREATE TABLE Employee
(
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2)
);
GO

INSERT INTO Employee (EmpId, EmpName, Department, Salary)
VALUES
(101,'Nagarjuna','AIML',75000),
(102,'Rahul','IT',55000),
(103,'Anjali','HR',45000),
(104,'Kiran','Finance',60000);
GO

SELECT * FROM Employee;
GO