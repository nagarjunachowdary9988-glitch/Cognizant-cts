USE CTS_Training;
GO

-- Create Sales Table
CREATE TABLE Sales
(
    Department VARCHAR(50),
    Year INT,
    Amount INT
);
GO

-- Insert Sample Data
INSERT INTO Sales VALUES
('IT',2023,50000),
('HR',2023,30000),
('Finance',2023,45000),
('IT',2024,70000),
('HR',2024,35000),
('Finance',2024,50000);
GO

-- PIVOT Example
SELECT *
FROM
(
    SELECT Department, Year, Amount
    FROM Sales
) AS SourceTable
PIVOT
(
    SUM(Amount)
    FOR Year IN ([2023],[2024])
) AS PivotTable;
GO

-- UNPIVOT Example
SELECT Department, Year, Amount
FROM
(
    SELECT Department,[2023],[2024]
    FROM
    (
        SELECT Department, Year, Amount
        FROM Sales
    ) AS SourceTable
    PIVOT
    (
        SUM(Amount)
        FOR Year IN ([2023],[2024])
    ) AS PivotTable
) AS P
UNPIVOT
(
    Amount FOR Year IN ([2023],[2024])
) AS UnpivotTable;
GO