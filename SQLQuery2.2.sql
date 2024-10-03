SELECT DISTINCT P.ProductName
FROM Products AS P
JOIN [Order Details] AS OD ON P.ProductID = OD.ProductID
JOIN Orders AS O ON OD.OrderID = O.OrderID
WHERE O.OrderDate >= DATEADD(YEAR, -27, GETDATE());

SELECT TOP 5 C.PostalCode, SUM(OD.Quantity) AS TotalSold
FROM Customers AS C
JOIN Orders AS O ON C.CustomerID = O.CustomerID
JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
GROUP BY C.PostalCode
ORDER BY TotalSold DESC;

SELECT TOP 5 C.PostalCode, SUM(OD.Quantity) AS TotalSold
FROM Customers AS C
JOIN Orders AS O ON C.CustomerID = O.CustomerID
JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
WHERE O.OrderDate >= DATEADD(YEAR, -27, GETDATE())
GROUP BY C.PostalCode
ORDER BY TotalSold DESC;

SELECT C.City, COUNT(*) AS CustomerCount
FROM Customers AS C
GROUP BY C.City;

SELECT C.City, COUNT(*) AS CustomerCount
FROM Customers AS C
GROUP BY C.City
HAVING COUNT(*) > 2;

SELECT DISTINCT C.ContactName, O.OrderDate
FROM Customers AS C
JOIN Orders AS O ON C.CustomerID = O.CustomerID
WHERE O.OrderDate > '1998-01-01';

SELECT C.ContactName
FROM Customers AS C
JOIN Orders AS O ON C.CustomerID = O.CustomerID
WHERE O.OrderDate = (SELECT MAX(OrderDate) FROM Orders);

SELECT C.ContactName, COUNT(OD.ProductID) AS ProductCount
FROM Customers AS C
JOIN Orders AS O ON C.CustomerID = O.CustomerID
JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
GROUP BY C.ContactName;

SELECT C.CustomerID, COUNT(OD.ProductID) AS ProductCount
FROM Customers AS C
JOIN Orders AS O ON C.CustomerID = O.CustomerID
JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
GROUP BY C.CustomerID
HAVING COUNT(OD.ProductID) > 100;

SELECT DISTINCT S.CompanyName AS SupplierCompanyName, 
       SH.CompanyName AS ShippingCompanyName
FROM Suppliers AS S
JOIN Shippers AS SH ON S.SupplierID = SH.ShipperID;  -- Adjust as necessary based on your schema

SELECT O.OrderDate, P.ProductName
FROM Orders AS O
JOIN [Order Details] AS OD ON O.OrderID = OD.OrderID
JOIN Products AS P ON OD.ProductID = P.ProductID
ORDER BY O.OrderDate;

SELECT E1.FirstName + ' ' + E1.LastName AS Employee1,
       E2.FirstName + ' ' + E2.LastName AS Employee2,
       E1.Title
FROM Employees AS E1
JOIN Employees AS E2 ON E1.Title = E2.Title AND E1.EmployeeID < E2.EmployeeID;

SELECT E.FirstName + ' ' + E.LastName AS ManagerName, COUNT(E2.EmployeeID) AS EmployeeCount
FROM Employees AS E
JOIN Employees AS E2 ON E.EmployeeID = E2.ReportsTo
GROUP BY E.FirstName, E.LastName
HAVING COUNT(E2.EmployeeID) > 2;




SELECT C.City, C.CompanyName AS Name, C.ContactName, 'Customer' AS Type
FROM Customers AS C
UNION ALL
SELECT S.City, S.CompanyName AS Name, S.ContactName, 'Supplier' AS Type
FROM Suppliers AS S;
