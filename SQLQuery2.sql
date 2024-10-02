use AdventureWorks2019
GO

select ProductID, Name, Color ,ListPrice from Production.Product 

select ProductID, Name, Color ,ListPrice from Production.Product where not ListPrice = 0

select ProductID, Name, Color ,ListPrice from Production.Product where Color is NULL

select ProductID, Name, Color ,ListPrice from Production.Product where Color is not NULL

select ProductID, Name, Color ,ListPrice from Production.Product where Color is not NULL and ListPrice>0

SELECT CONCAT(Name, ' ', Color) AS ProductInfo
FROM Production.Product
WHERE Color IS NOT NULL;

SELECT CONCAT('NAME:'+Name, ' '+'-- COLOR: '+ Color) AS ProductInfo
FROM Production.Product
WHERE Color IS NOT NULL;   

select  ProductID,Name from Production.Product where ProductID between 400 and 500

--select ProductID, Name , color from Production.Product where  Color = blue or black;

SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color IN ('Black', 'Blue');

select * from Production.Product where Name like 'S%'

SELECT Name, ListPrice
FROM Production.Product where Name like 'S%'
ORDER BY Name;

SELECT Name, ListPrice
FROM Production.Product where Name like 'S%' or Name like 'A%'
ORDER BY Name;  

SELECT Name, ListPrice
FROM Production.Product where Name like 'SPO[^K]%'
ORDER BY Name;

select distinct Color
from Production.Product where Color is not NULL
order by Color Desc