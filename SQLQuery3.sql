SELECT DISTINCT E.City 
FROM Employees AS E
INTERSECT
SELECT DISTINCT C.City
FROM Customers AS C

select DISTINCT e.city
from Employees e join Customers c on e.city=c.city

select DISTINCT e.city
from Employees e
where e.city in (select DISTINCT c.city
from Customers c)

SELECT P.ProductName, SUM(OD.Quantity) AS TotalOrderQuantity
FROM Products AS P
JOIN [Order Details] AS OD ON P.ProductID = OD.ProductID
GROUP BY P.ProductName
ORDER BY TotalOrderQuantity DESC;

--3
SELECT P.ProductName, SUM(OD.Quantity) AS TotalOrderQuantity
FROM Products AS P
JOIN [Order Details] AS OD ON P.ProductID = OD.ProductID
GROUP BY P.ProductName
ORDER BY TotalOrderQuantity DESC;

SELECT C.City, SUM(OD.Quantity) AS TotalProductsOrdered
FROM Customers AS C
JOIN Orders AS O ON C.CustomerID = O.CustomerID
JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
GROUP BY C.City
ORDER BY TotalProductsOrdered DESC;

SELECT C.City, COUNT(DISTINCT C.CustomerID) AS CustomerCount
FROM Customers AS C
GROUP BY C.City
HAVING COUNT(DISTINCT C.CustomerID) >= 2;

SELECT C.City, COUNT(DISTINCT OD.ProductID) AS ProductCount
FROM Customers AS C
JOIN Orders AS O ON C.CustomerID = O.CustomerID
JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
GROUP BY C.City
HAVING COUNT(DISTINCT OD.ProductID) >= 2;

SELECT C.CustomerID, C.ContactName, C.City AS CustomerCity, O.ShipCity AS ShipCity
FROM Customers AS C
JOIN Orders AS O ON C.CustomerID = O.CustomerID
WHERE C.City <> O.ShipCity;



WITH ProductTotals AS (
    SELECT P.ProductID, P.ProductName, AVG(OD.UnitPrice) AS AvgPrice, SUM(OD.Quantity) AS TotalQuantity
    FROM Products AS P
    JOIN [Order Details] AS OD ON P.ProductID = OD.ProductID
    GROUP BY P.ProductID, P.ProductName
),
TopProducts AS (
    SELECT TOP 5 PT.ProductID, PT.ProductName, PT.AvgPrice
    FROM ProductTotals AS PT
    ORDER BY PT.TotalQuantity DESC
)
SELECT TP.ProductName, TP.AvgPrice, C.City AS CustomerCity, SUM(OD.Quantity) AS OrderedQuantity
FROM TopProducts AS TP
JOIN [Order Details] AS OD ON TP.ProductID = OD.ProductID
JOIN Orders AS O ON OD.OrderID = O.OrderID
JOIN Customers AS C ON O.CustomerID = C.CustomerID
GROUP BY TP.ProductName, TP.AvgPrice, C.City
ORDER BY OrderedQuantity DESC;


--9a
SELECT DISTINCT E.City
FROM Employees AS E
WHERE E.City NOT IN (
    SELECT DISTINCT C.City
    FROM Customers AS C
    JOIN Orders AS O ON C.CustomerID = O.CustomerID
);

--9b
SELECT DISTINCT E.City
FROM Employees AS E
LEFT JOIN Customers AS C ON E.City = C.City
LEFT JOIN Orders AS O ON C.CustomerID = O.CustomerID
WHERE O.OrderID IS NULL;


WITH EmployeeOrderCount AS (
    SELECT E.City, COUNT(O.OrderID) AS OrderCount
    FROM Employees AS E
    JOIN Orders AS O ON E.EmployeeID = O.EmployeeID
    GROUP BY E.City
),
CustomerOrderCount AS (
    SELECT C.City, SUM(OD.Quantity) AS TotalQuantity
    FROM Customers AS C
    JOIN Orders AS O ON C.CustomerID = O.CustomerID
    JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
    GROUP BY C.City
)
SELECT EOC.City
FROM EmployeeOrderCount AS EOC
JOIN CustomerOrderCount AS COC ON EOC.City = COC.City
ORDER BY EOC.OrderCount DESC, COC.TotalQuantity DESC
OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY;

--11 Using DISTINCT to select unique rows
