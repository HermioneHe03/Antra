--Chen He
--Assignment 2

--Solution 14
SELECT p.ProductName
FROM dbo.Products p INNER JOIN dbo.[Order Details] d ON p.ProductID = d.ProductID INNER JOIN dbo.Orders  o ON d.OrderID = o.OrderID
WHERE d.Quantity >= 1 AND o.OrderDate > '19970413'

--Solution 15
SELECT TOP 5 c.PostalCode
FROM dbo.Customers c INNER JOIN dbo.Orders o ON c.CustomerID = o.CustomerID INNER JOIN dbo.[Order Details] d ON d.OrderID = o.OrderID
WHERE c.PostalCode IS NOT NULL
GROUP BY c.PostalCode
ORDER BY SUM(d.Quantity) DESC


--Solution 16
SELECT TOP 5 c.PostalCode
FROM dbo.Customers c INNER JOIN dbo.Orders o ON c.CustomerID = o.CustomerID INNER JOIN dbo.[Order Details] d ON d.OrderID = o.OrderID
WHERE c.PostalCode IS NOT NULL AND o.OrderDate > '19970413'
GROUP BY c.PostalCode
ORDER BY SUM(d.Quantity) DESC


--Solution 17
SELECT City, COUNT(CustomerID) AS NumofCus
FROM dbo.Customers
GROUP BY City


--Solution 18
SELECT City, COUNT(CustomerID) AS NumofCus
FROM dbo.Customers
GROUP BY City
HAVING COUNT(CustomerID) >2


--Solution 19
SELECT c.ContactName, o.OrderDate
FROM dbo.Customers c INNER JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '19980101'


--Solution 20
SELECT c.ContactName, MAX(o.OrderDate)
FROM dbo.Customers c INNER JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName


--Solution 21
SELECT c.ContactName, SUM(d.Quantity) AS CouofPro
FROM dbo.Customers c INNER JOIN dbo.Orders o ON c.CustomerID = o.CustomerID INNER JOIN dbo.[Order Details] d ON d.OrderID = o.OrderID
GROUP BY c.ContactName

--Solution 22
SELECT c.CustomerID, SUM(d.Quantity) AS CouofPro
FROM dbo.Customers c INNER JOIN dbo.Orders o ON c.CustomerID = o.CustomerID INNER JOIN dbo.[Order Details] d ON d.OrderID = o.OrderID
GROUP BY c.CustomerID
HAVING SUM(d.Quantity) >100


--Solution 23
SELECT su.CompanyName AS [Supplier Company Name], sh.CompanyName AS [Shipping Company Name]
FROM dbo.Shippers sh INNER JOIN dbo.Orders o ON sh.ShipperID = o.ShipVia INNER JOIN dbo.[Order Details] d ON d.OrderID = o.OrderID 
INNER JOIN dbo.Products p ON p.ProductID = d.ProductID INNER JOIN dbo.Suppliers su ON su.SupplierID = p.SupplierID
GROUP BY su.CompanyName, sh.CompanyName
ORDER BY su.CompanyName

--Solution 24
SELECT o.OrderDate, p.ProductName
FROM dbo.Orders o INNER JOIN dbo.[Order Details] d ON o.OrderID = d.OrderID INNER JOIN dbo.Products p ON p.ProductID = d.ProductID
ORDER BY o.OrderDate


--Solution 25
SELECT e1.FirstName + ' ' + e1.LastName AS Employee1, e2.FirstName + ' ' + e2.LastName AS Employee2
FROM dbo.Employees e1 INNER JOIN dbo.Employees e2 ON e1.Title = e2.Title
WHERE  e1.FirstName + ' ' + e1.LastName != e2.FirstName + ' ' + e2.LastName



--Solution 26
SELECT m.FirstName + ' ' + m.LastName AS ManagerName, COUNT(e.ReportsTo) AS NumofReporters
FROM dbo.Employees m INNER JOIN dbo.Employees e ON m.EmployeeID = e.ReportsTo
GROUP BY m.FirstName + ' ' + m.LastName



--Solution 27
SELECT c.City, c.CompanyName, c.ContactName, 'Customer' AS Type
FROM dbo.Customers c
UNION
SELECT s.City, s.CompanyName, s.ContactName, 'Supplier' AS Type
FROM dbo.Suppliers s