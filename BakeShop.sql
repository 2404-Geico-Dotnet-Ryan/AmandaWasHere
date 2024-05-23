DROP TABLE Food;
----Create - DDL Command - part of defining rules
CREATE TABLE Food (
	Id INT IDENTITY PRIMARY KEY, 
	ItemName VARCHAR(50) UNIQUE NOT NULL,
	Price DECIMAL(12,2), 
	InStock BIT DEFAULT 1,
	UserId INT,
	CONSTRAINT FK_Movie_User FOREIGN KEY (UserId) REFERENCES [User](Id)
	);

--INSERT INTO Food Values
--(1, 'Plain Bagel', 1.49, 1, 0),
--(2, 'Everything Bagel', 1.99, 1, 0),
--(3, 'Cinnamon Raisin Bagel', 2.09, 1, 0),
--(4, 'Chocolate Chip Cookies', 1.50, 1, 0),
--(5, 'Peanut Butter Cookies', 1.50, 1, 0),
--(6, 'Salted Caramel Cookies', 1.50, 1, 0),
--(7, 'Sourdough Bread', 4.87, 1, 0),
--(8, 'Sandwich Bread', 4.87, 1, 0),
--(9, 'Artisan Bread', 4.87, 1, 0);

--CREATE TABLE Logins(
--	Id int, 
--	Role varchar(50),
--	UserName varchar(50), 
--	Password varchar(5)
--);
--EXEC sp_rename 'Logins', 'Login';