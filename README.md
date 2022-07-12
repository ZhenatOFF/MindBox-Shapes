# Задача
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
# Решение
Сначала создаем таблицы продуктов и категорий:
```
CREATE TABLE Products
(
	Id INT PRIMARY KEY,
	Product NVARCHAR(50)
)

CREATE TABLE Categories
(
	Id INT PRIMARY KEY,
	Category NVARCHAR(50)
)
```
Заполняем их:
```
INSERT INTO Products 
VALUES
	(1, 'Сыр сливочный'),
	(2, 'Кефир'),
	(3, 'Говядина')

INSERT INTO Categories 
VALUES
	(1, 'Молочные продукты'),
	(2, 'Cыры'),
	(3, 'Вегетарианские продукты')
```
Создаем таблицу продуктов и их категорий и заполняем ее:
```
CREATE TABLE ProductsAndCategories
(
	ProductId INT REFERENCES Products(Id),
	CategoryId INT REFERENCES Categories(Id)
	PRIMARY KEY(ProductId, CategoryId)
)

INSERT INTO ProductsAndCategories
VALUES
	(1,1),
	(1,2),
	(1,3),
	(2,1),
	(2,3)
```
SQL запрос для выбора всех пар «Имя продукта – Имя категории»:
```
SELECT P.Product, C.Category FROM Products AS P
LEFT JOIN ProductsAndCategories AS PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories AS C
	ON PC.CategoryId = C.Id
```
