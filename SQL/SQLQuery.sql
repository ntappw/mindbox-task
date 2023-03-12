CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Products
VALUES
	(1, 'Table 60 cm white'),
	(2, 'Apple Krasn'),
	(3, 'Chair metal'),
	(4, 'Orange Turk'),
	(5, 'Mouse gray');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Categories
VALUES
	(1, 'Kitchen'),
	(2, 'Furniture'),
	(3, 'Book'),
	(4, 'Food'),
	(5, 'Fruit');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 2),
	(1, 1),
	(2, 4),
	(2, 5),
	(3, 1),
	(3, 2),
	(4, 4),
	(4, 5);

SELECT P."Name", C."Name" AS 'Category'
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;