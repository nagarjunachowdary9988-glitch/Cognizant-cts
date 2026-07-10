USE CTS_Training;
GO

-- Drop procedure if it already exists
IF OBJECT_ID('sp_GetEmployees', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetEmployees;
GO

-- Create Stored Procedure
CREATE PROCEDURE sp_GetEmployees
AS
BEGIN
    SELECT * FROM Employee;
END;
GO

-- Execute Stored Procedure
EXEC sp_GetEmployees;
GO