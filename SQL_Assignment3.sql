--Chen He
--Assignment 3


--Solution 1
SELECT DISTINCT c.City
FROM Customers c INNER JOIN Employees e ON c.City = e.City

--Solution 2.a
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN 
(
SELECT DISTINCT City
FROM Employees)

--Solution 2.b
SELECT DISTINCT City FROM Customers
EXCEPT
SELECT DISTINCT City FROM Employees

--Solution 3
SELECT p.ProductName, SUM(d.Quantity) AS TotalQuantities
FROM Products p INNER JOIN [Order Details] d ON p.ProductID = d.ProductID
GROUP BY p.ProductName

--Solution 4
SELECT c.City, SUM(d.Quantity) AS TotalQuantities
FROM Customers c INNER JOIN Orders o ON c.CustomerID = o.CustomerID INNER JOIN [Order Details] d ON o.OrderID = d.OrderID
GROUP BY c.City

--Solution 5.a
SELECT DISTINCT City
FROM Customers
EXCEPT
(SELECT DISTINCT City FROM Customers
GROUP BY City HAVING COUNT(*) = 1
UNION
SELECT DISTINCT City FROM Customers
GROUP BY City HAVING COUNT(*) = 0)


--Solution 5.b
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN
(
SELECT DISTINCT City
FROM Customers
GROUP BY City
HAVING COUNT(*) = 1 OR COUNT(*) = 0)

--Solution 6
SELECT DISTINCT c.City
FROM Customers c INNER JOIN Orders o ON c.CustomerID = o.CustomerID INNER JOIN [Order Details] d ON o.OrderID = d.OrderID
GROUP BY c.City
HAVING COUNT(d.ProductID) >= 2

--Solution 7
SELECT DISTINCT c.ContactName 
FROM Orders o INNER JOIN Customers c ON c.customerID=o.CustomerID
WHERE c.City != o.ShipCity

--Solution 8
SELECT TOP 5 ProductID, AVG(UnitPrice) AS AvgPrice, (SELECT TOP 1 City FROM Customers c INNER JOIN Orders o ON o.CustomerID=c.CustomerID INNER JOIN [Order Details] d1 ON d1.OrderID=o.OrderID  WHERE d1.ProductID = d2.ProductID GROUP BY c.City ORDER BY SUM(d1.Quantity) DESC) AS City
FROM [Order Details] d2
GROUP BY ProductID 
ORDER BY SUM(Quantity) DESC

--Solution 9.a
SELECT City
FROM Employees
WHERE City NOT IN (
SELECT ShipCity
FROM Orders)

--Solution 9.b
SELECT City
FROM Employees
EXCEPT
SELECT ShipCity
FROM Orders

--Solution 10
SELECT 
(SELECT TOP 1 e.City FROM Employees e INNER JOIN Orders o ON e.EmployeeID = o.EmployeeID GROUP BY o.EmployeeID, e.City ORDER BY COUNT(o.OrderID) DESC) AS MostOrdersCity,
(SELECT TOP 1 e.City FROM Employees e INNER JOIN Orders o ON e.EmployeeID = o.EmployeeID INNER JOIN [Order Details] d ON d.OrderID = o.OrderID  GROUP BY o.EmployeeID, e.City ORDER BY SUM(d.Quantity) DESC) AS MostQuantityCity


--Solution 11
--Use DISTINCT could remove the duplicates record of a table.