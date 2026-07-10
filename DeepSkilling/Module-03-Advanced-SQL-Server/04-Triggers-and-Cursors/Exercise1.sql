USE CTS_Training;
GO

-- Drop Trigger if it already exists
IF OBJECT_ID('trg_Employee_Insert', 'TR') IS NOT NULL
    DROP TRIGGER trg_Employee_Insert;
GO

-- Create Trigger
CREATE TRIGGER trg_Employee_Insert
ON Employee
AFTER INSERT
AS
BEGIN
    PRINT 'Employee record inserted successfully.';
END;
GO

-- Test Trigger
INSERT INTO Employee
VALUES (107, 'Ravi', 'Testing', 52000);
GO

-- Display Data
SELECT * FROM Employee;
GO