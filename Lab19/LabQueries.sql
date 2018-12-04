--Lab 19
SELECT *
FROM Customers;

SELECT DISTINCT Country
FROM Customers;

SELECT *
FROM Customers
WHERE CustomerID LIKE 'BL%';

SELECT TOP 100 *
FROM Orders;

SELECT *
FROM Customers
WHERE PostalCode IN ('1010', '3012', '12209', '05023');

SELECT *
FROM Orders
WHERE ShipRegion IS NOT NULL;

SELECT *
FROM Customers
ORDER BY Country, City;

--DELETE FROM Customers
--WHERE CustomerID = 'ABCDE';

INSERT INTO Customers
VALUES ('ABCDE', 'Whatever Co', 'Jim Bob', 'WhatsIt', '123 Anywhere', 'Anywhere', 'QS', '1234', 'United States', '(1) 123-1234', '(1) 123-1234');

UPDATE Orders
SET ShipRegion = 'EuroZone'
WHERE ShipCountry = 'France';

DELETE FROM [Order Details]
WHERE Quantity = 1;

SELECT avg(quantity) as AverageValue, max(quantity) as MaxValue, min(quantity) as MinValue
FROM [Order Details]

SELECT avg(quantity) as AverageValue, max(quantity) as MaxValue, min(quantity) as MinValue, OrderID
FROM [Order Details]
GROUP BY OrderID

SELECT CustomerID
FROM Orders
WHERE OrderID = 10290;

SELECT *
FROM Orders 
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

SELECT *
FROM Orders 
LEFT JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

SELECT *
FROM Orders 
RIGHT JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

SELECT FirstName
FROM Employees
WHERE ReportsTo IS NULL;

SELECT FirstName
FROM Employees
WHERE ReportsTo =
(SELECT EmployeeID
FROM Employees
WHERE FirstName = 'Andrew');

--Bonus 20
SELECT *
FROM Customers;

SELECT *
FROM Customers
WHERE City IN ('London', 'Paris');

SELECT DISTINCT City
FROM Customers;

SELECT FirstName
FROM Employees
ORDER BY FirstName;

SELECT FORMAT (avg(Salary), 'C', 'en-us') as AvgSalary
FROM Salaries;

SELECT TOP 1 FORMAT (Salary, 'C', 'en-us') as AvgSalary, Employees.EmployeeID, LastName, FirstName
FROM Salaries
LEFT JOIN Employees ON Salaries.EmployeeID = Employees.EmployeeID
ORDER BY Salary DESC;

SELECT *
FROM Employees
WHERE Notes LIKE '%BA%';

SELECT *
FROM [Summary of Sales by Year];

SELECT *
FROM Employees
WHERE HireDate > Convert(datetime, '1994-1-1');

SELECT FirstName, DATEDIFF(year, HireDate, GETDATE()) as TimeWorked
FROM Employees;

SELECT *
FROM Products
ORDER BY (UnitsInStock+UnitsOnOrder);

SELECT *
FROM Products
ORDER BY (UnitsInStock+UnitsOnOrder) DESC;

SELECT *
FROM Products
WHERE (UnitsInStock + UnitsOnOrder) < 6;

SELECT *
FROM Products
WHERE Discontinued = 1;

SELECT *
FROM Products
WHERE ProductName LIKE '%tofu%';

SELECT TOP 1 *
FROM Products
ORDER BY UnitPrice DESC;

SELECT *
FROM Employees
WHERE HireDate > Convert(datetime, '1993-1-1');

SELECT *
FROM Employees
WHERE TitleOfCourtesy IN ('Ms.', 'Mrs.');

SELECT *
FROM Employees
WHERE HomePhone LIKE '(206%';

SELECT      COLUMN_NAME AS 'ColumnName'
            ,TABLE_NAME AS  'TableName'
FROM        INFORMATION_SCHEMA.COLUMNS
--WHERE       COLUMN_NAME LIKE '%pay%'
ORDER BY    TableName
            ,ColumnName;

