CREATE TABLE Products(id INT PRIMARY KEY, name VARCHAR(255) NOT NULL);
CREATE TABLE Category(id INT PRIMARY KEY, name VARCHAR(255) NOT NULL);
CREATE TABLE ProductCategory(product_id INT NOT NULL, category_id INT NOT NULL);

INSERT INTO Products VALUES(1, 'Огурец'), (2, 'Картофель'), (3, 'Яблоко'), (4, 'Древесина');
INSERT INTO Category VALUES(1, 'Овощи'), (2, 'Зеленые предметы');
INSERT INTO ProductCategory VALUES(1, 1), (2, 1), (1, 2), (3, 2);