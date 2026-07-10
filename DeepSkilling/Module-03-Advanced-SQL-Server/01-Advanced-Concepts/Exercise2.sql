USE CTS_Training;
GO

-- Display Employee Details

SELECT * FROM Employee;
GO

-- ROW_NUMBER()

SELECT
    EmpId,
    EmpName,
    Department,
    Salary,
    ROW_NUMBER() OVER(ORDER BY Salary DESC) AS RowNumber
FROM Employee;
GO

-- RANK()

SELECT
    EmpId,
    EmpName,
    Department,
    Salary,
    RANK() OVER(ORDER BY Salary DESC) AS RankValue
FROM Employee;
GO

-- DENSE_RANK()

SELECT
    EmpId,
    EmpName,
    Department,
    Salary,
    DENSE_RANK() OVER(ORDER BY Salary DESC) AS DenseRank
FROM Employee;
GO

-- PARTITION BY

SELECT
    EmpId,
    EmpName,
    Department,
    Salary,
    ROW_NUMBER() OVER(PARTITION BY Department ORDER BY Salary DESC) AS DepartmentRank
FROM Employee;
GO