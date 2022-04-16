--Chen He
--Assignment 4

--Solution 1
CREATE VIEW View_Product_Order_He
AS
SELECT ProductName, SUM(Quantity) As TotalQty FROM [Order Details] OD JOIN Products P ON P.ProductID = OD.ProductID
GROUP BY ProductName

--Solution 2
CREATE PROC sp_Product_Order_Quantity_He
@ProductID INT,
@TotalQty INT OUT
AS
BEGIN
SELECT @TotalQty = SUM(Quantity)  FROM [Order Details] d JOIN Products p ON p.ProductID = d.ProductID
WHERE P.ProductID = @ProductID
GROUP BY ProductName
END

DECLARE @Total INT
EXEC sp_Product_Order_Quantity_He 11,@Total OUT
PRINT @Total 

--Solution 3
CREATE PROC sp_Product_Order_City_He
@ProductName NVARCHAR(50)
AS
BEGIN
SELECT TOP 5 ShipCity,SUM(Quantity) FROM [Order Details] d JOIN Products p ON P.ProductID = d.ProductID JOIN Orders o ON o.OrderID = d.OrderID
WHERE ProductName=@ProductName
GROUP BY ProductName,ShipCity
ORDER BY SUM(Quantity) DESC
END

--Solution 4
CREATE TABLE People_He
(
Id INT ,
[Name] varchar(20),
City INT
)

CREATE TABLE City_He
(
Id INT,
City varchar(20)
)
BEGIN TRAN 
INSERT INTO City_He VALUES(1,'Seattle')
INSERT INTO City_He VALUES(2,'Green Bay')

INSERT INTO People_He VALUES(1,'Aaron Rodgers',2)
INSERT INTO People_He VALUES(2,'Russell Wilson',1)
INSERT INTO People_He VALUES(3,'Jody Nelson',2)

IF EXISTS(SELECT Id from People_He where City = (SELECT Id FROM City_He WHERE City = 'Seatle'))
BEGIN
INSERT INTO City_He VALUES(3,'Madison')
UPDATE People_He
SET City = 'Madison'
WHERE Id IN (SELECT Id FROM People_He WHERE City = (SELECT Id FROM City_He WHERE City = 'Seatle'))
END
DELETE FROM City_He WHERE City = 'Seattle'

CREATE VIEW Packers_He
AS
SELECT [Name] FROM People_He WHERE City = 'Green Bay'


DROP TABLE People_He
DROP TABLE City_He
DROP VIEW Packers_He

--Solution 5
CREATE PROC sp_Birthday_Employee_He
AS
BEGIN
SELECT * INTO Birthday_Employee_He
FROM Employees WHERE DATEPART(MM,BirthDate) = 02
SELECT * FROM Birthday_Employee_He
END

DROP TABLE Birthday_Employee_He

--Solution 6
--1. UNION could help us to compare two tables: if table1 and table2 have the same data. The row number of result should be same as table1 & 2.
	--SELECT * FROM table1
	--UNION
	--SELECT * FROM table2
--2.CHECKSUM could help us to compare two tables:if the result becomes null, these two tables have the same data.
	--SELECT * FROM table1
	--WHERE CHECKSUM(*) NOT IN
	--(SELECT CHECKSUM(*) FROM table2)
--3.Use EXCEPT to minus two table: if the result becomes null, these two tables have the same data.
