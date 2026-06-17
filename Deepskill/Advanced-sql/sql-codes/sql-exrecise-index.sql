CREATE TABLE Products (
    ProductID INT,
    ProductName VARCHAR(50),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);
INSERT INTO Products VALUES
(1,'Laptop','Electronics',80000),
(2,'Mobile','Electronics',60000),
(3,'Tablet','Electronics',60000),
(4,'Headphones','Electronics',10000),
(5,'Shirt','Fashion',2000),
(6,'Jeans','Fashion',3000),
(7,'Jacket','Fashion',3000),
(8,'Shoes','Fashion',5000);
#1.row number
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNum
FROM Products;
#Rank
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RankNo
FROM Products;
#DENSE_RANK()
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRankNo
FROM Products;

