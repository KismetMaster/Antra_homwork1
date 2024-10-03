select * from Production.Product
select * from Production.ProductInventory

select COUNT(*) from Production.Product

select COUNT(*) from Production.Product where  Product.ProductSubcategoryID is not NULL

select Product.ProductSubcategoryID,COUNT(*) as CountedProducts from Production.Product where  Product.ProductSubcategoryID is not NULL group by Product.ProductSubcategoryID

select COUNT(*) from Production.Product where  Product.ProductSubcategoryID is NULL

SELECT ProductID, SUM(Quantity) AS TotalQuantity
FROM Production.ProductInventory
GROUP BY ProductID;

SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100;

SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100;

select distinct ProductID , AVG(Quantity) as averagequantity
FROM Production.ProductInventory 
where LocationID=10
GROUP BY ProductID

--9
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf;

SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY ProductID, Shelf;

SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class;

SELECT CR.Name AS Country, SP.Name AS Province
FROM Person.CountryRegion CR
INNER JOIN Person.StateProvince SP
    ON CR.CountryRegionCode = SP.CountryRegionCode;

SELECT CR.Name AS Country, SP.Name AS Province
FROM Person.CountryRegion CR
INNER JOIN Person.StateProvince SP
    ON CR.CountryRegionCode = SP.CountryRegionCode
WHERE CR.Name IN ('Germany', 'Canada');



