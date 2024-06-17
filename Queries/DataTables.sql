-- Вставка данных в таблицу Products
INSERT INTO Products (ProductName)
VALUES 
('Product A'),
('Product B'),
('Product C');

-- Вставка данных в таблицу ProductCategories
INSERT INTO ProductCategories (CategoryName)
VALUES 
('Category X'),
('Category Y'),
('Category Z');

-- Вставка данных в таблицу ProductCategoryMapping
INSERT INTO ProductCategoryMapping (ProductID, CategoryID)
VALUES 
(1, 1),
(1, 2),
(2, 2);