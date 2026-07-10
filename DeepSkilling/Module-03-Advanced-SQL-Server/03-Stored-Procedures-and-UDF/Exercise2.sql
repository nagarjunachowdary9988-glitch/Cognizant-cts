USE CTS_Training;
GO

-- Drop function if it already exists
IF OBJECT_ID('dbo.fn_GetAnnualSalary', 'FN') IS NOT NULL
    DROP FUNCTION dbo.fn_GetAnnualSalary;
GO

-- Create Scalar Function
CREATE FUNCTION dbo.fn_GetAnnualSalary
(
    @Salary DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN @Salary * 12;
END;
GO

-- Use Function
SELECT
    EmpId,
    EmpName,
    Salary,
    dbo.fn_GetAnnualSalary(Salary) AS AnnualSalary
FROM Employee;
GO