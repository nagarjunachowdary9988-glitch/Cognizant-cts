USE CTS_Training;
GO

-- Common Table Expression (CTE)

WITH EmployeeCTE AS
(
    SELECT
        EmpId,
        EmpName,
        Department,
        Salary
    FROM Employee
)

SELECT *
FROM EmployeeCTE;
GO

-- CTE with Salary Filter

WITH HighSalaryEmployees AS
(
    SELECT
        EmpId,
        EmpName,
        Department,
        Salary
    FROM Employee
    WHERE Salary > 50000
)

SELECT *
FROM HighSalaryEmployees;
GO