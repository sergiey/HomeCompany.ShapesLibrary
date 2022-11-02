-- Creating table
USE productsdb;

CREATE TABLE Products
(
    ProductId INT IDENTITY PRIMARY KEY,
    ProductName NVARCHAR(30) NOT NULL
);

CREATE TABLE Categories
(
    CategoryId INT IDENTITY PRIMARY KEY,
    CategoryName NVARCHAR(30) NOT NULL
);

CREATE TABLE CategoryLink
(
    ProductId INT NOT NULL
        REFERENCES Products (ProductId),
    CategoryId INT
        REFERENCES Categories (CategoryId)
);

INSERT INTO Products
VALUES ('Paper Towels'),
('A23 Battery'),
('Air Freshener'),
('Laundry Softener'),
('Ibuprofen Tablets'),
('Gel Pens')

INSERT INTO Categories
VALUES ('Health & Household'),
('Supplies'),
('Laundry')

INSERT INTO CategoryLink
VALUES
(
    (
        SELECT ProductId FROM Products WHERE ProductName = 'Paper Towels'
    ),
    (
        SELECT CategoryId
        FROM Categories
        WHERE CategoryName = 'Health & Household'
    )
),
(
    (
        SELECT ProductId FROM Products WHERE ProductName = 'Paper Towels'
    ),
    (
        SELECT CategoryId FROM Categories WHERE CategoryName = 'Supplies'
    )
),
(
    (
        SELECT ProductId FROM Products WHERE ProductName = 'A23 Battery'
    ),
    (
        SELECT CategoryId FROM Categories WHERE CategoryName = 'Supplies'
    )
),
(
    (
        SELECT ProductId FROM Products WHERE ProductName = 'Air Freshener'
    ),
    (
        SELECT CategoryId
        FROM Categories
        WHERE CategoryName = 'Health & Household'
    )
),
(
    (
        SELECT ProductId FROM Products WHERE ProductName = 'Laundry Softener'
    ),
    (
        SELECT CategoryId FROM Categories WHERE CategoryName = 'Laundry'
    )
),
(
    (
        SELECT ProductId FROM Products WHERE ProductName = 'Laundry Softener'
    ),
    (
        SELECT CategoryId
        FROM Categories
        WHERE CategoryName = 'Health & Household'
    )
),
(
    (
        SELECT ProductId FROM Products WHERE ProductName = 'Ibuprofen Tablets'
    ),
    (
        SELECT CategoryId
        FROM Categories
        WHERE CategoryName = 'Health & Household'
    )
),
(
    (
        SELECT ProductId FROM Products WHERE ProductName = 'Gel Pens'
    ),
    NULL
)


-- Query
SELECT Products.ProductName,
       Categories.CategoryName
FROM CategoryLink
    INNER JOIN Products
        ON CategoryLink.ProductId = Products.ProductId
    LEFT OUTER JOIN Categories
        ON CategoryLink.CategoryId = Categories.CategoryId