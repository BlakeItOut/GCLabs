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

