USE CTS_Training;
GO

DECLARE @EmpName VARCHAR(50);

DECLARE EmployeeCursor CURSOR FOR
SELECT EmpName
FROM Employee;

OPEN EmployeeCursor;

FETCH NEXT FROM EmployeeCursor INTO @EmpName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @EmpName;
    FETCH NEXT FROM EmployeeCursor INTO @EmpName;
END;

CLOSE EmployeeCursor;
DEALLOCATE EmployeeCursor;
GO