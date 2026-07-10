USE CTS_Training;
GO

-- ROLLUP
SELECT
    Department,
    SUM(Salary) AS TotalSalary
FROM Employee
GROUP BY ROLLUP(Department);
GO

-- CUBE
SELECT
    Department,
    SUM(Salary) AS TotalSalary
FROM Employee
GROUP BY CUBE(Department);
GO

-- GROUPING SETS
SELECT
    Department,
    SUM(Salary) AS TotalSalary
FROM Employee
GROUP BY GROUPING SETS
(
    (Department),
    ()
);
GO