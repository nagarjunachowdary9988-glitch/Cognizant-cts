USE CTS_Training;
GO

-- Create Index
CREATE INDEX IX_Employee_Department
ON Employee(Department);
GO

-- Verify Data
SELECT * FROM Employee;
GO