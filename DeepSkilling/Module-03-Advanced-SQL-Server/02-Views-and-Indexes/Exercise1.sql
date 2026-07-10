USE CTS_Training;
GO

-- Create View
CREATE VIEW EmployeeView
AS
SELECT
    EmpId,
    EmpName,
    Department,
    Salary
FROM Employee;
GO

-- Display View
SELECT * FROM EmployeeView;
GO