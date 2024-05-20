--DROP TABLE [User];
CREATE TABLE [User] (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	UserName VARCHAR(50) UNIQUE NOT NULL,
	Password VARCHAR(50) NOT NULL,
	Role VARCHAR(50) NOT NULL CHECK (Role in ('User',
	'admin'))
);

INSERT INTO [User] VALUES ('Amanda', 'PaSsWoRd','Admin');
SELECT * FROM [User];
INSERT INTO [User] VALUES ('Elizabeth', 'password1','User');

INSERT INTO Food Values
('Plain Bagel', 1.49, default, default, NULL),
('Everything Bagel', 1.99, default, default, NULL),
('Cinnamon Raisin Bagel', 2.09, default, default, NULL),
('Chocolate Chip Cookies', 1.50, default, default, NULL),
('Peanut Butter Cookies', 1.50, default, default, NULL),
('Salted Caramel Cookies', 1.50, default, default, NULL),
('Sourdough Bread', 4.87, default, default, NULL),
('Sandwich Bread', 4.87, default, default, NULL),
('Artisan Bread', 4.87, default, default, NULL);