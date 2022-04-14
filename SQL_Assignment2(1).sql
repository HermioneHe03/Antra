--Chen He
--Assignment 2

--Solution 1
SELECT COUNT(DISTINCT ProductID)
FROM Production.Product

--Solution 2
SELECT COUNT(DISTINCT ProductSubcategoryID)
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

--Solution 3
SELECT ProductSubcategoryID, SUM(ProductsubcategoryID) AS CountedProducts
FROM Production.Product
GROUP BY ProductSubcategoryID

--Solution 4
SELECT COUNT(DISTINCT ProductID)
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

--Solution 5
SELECT SUM(Quantity)
FROM Production.ProductInventory

--Solution 6
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) <100


--Solution 7
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID, Shelf
HAVING SUM(Quantity) <100

--Solution 8
SELECT AVG(Quantity)
FROM Production.ProductInventory
WHERE LocationID = 10

--Solution 9
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY Shelf, ProductID

--Solution 10
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY Shelf, ProductID
ORDER BY Shelf

--Solution 11
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

--Solution 12
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c INNER JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
ORDER BY c.Name

--Solution 13
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c INNER JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany', 'Canada')
ORDER BY c.Name

