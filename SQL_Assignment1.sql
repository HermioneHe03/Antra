--Chen He
--Assignment 1

USE AdventureWorks2019
Go

--Solution 1
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product

--Solution 2
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice != 0

--Solution 3
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color is null

--Solution 4
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color is not null

--Solution 5
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice >0 AND Color is not null 

--Solution 6
SELECT 'NAME:' + Name + '-- COLOR:' + Color AS Con
FROM Production.Product
WHERE Color is not null


--Solution 7
SELECT 'NAME:' + Name + '-- COLOR:' + Color AS Con
FROM Production.Product
WHERE  Name LIKE '%Crankarm' or Name LIKE 'Chainring%'
ORDER BY ProductID


--Solution 8
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

--Solution 9
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color IN ('black', 'blue')

--Solution 10
SELECT *
FROM Production.Product
WHERE Name LIKE 'S%'

--Solution 11
SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE 'Seat%' or Name LIKE 'Short%' AND Size NOT IN ('L', 'XL')

--Solution 12
SELECT top 5 Name, ListPrice
FROM Production.Product
WHERE Name LIKE 'A%' OR Name LIKE 'S%'
ORDER BY Name

--Solution 13
SELECT *
FROM Production.Product
WHERE Name LIKE 'SPO[^K]%' 
ORDER BY Name

--Solution 14
SELECT DISTINCT Color
FROM Production.Product
ORDER BY Color DESC

--Solution 15
SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL