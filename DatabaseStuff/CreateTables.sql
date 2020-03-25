CREATE TABLE Stores(
	StoreID int NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	City varchar(50),
	State varchar(20)
)

CREATE TABLE Customers(
	CustomerID int NOT NULL IDENTITY (1001,1) PRIMARY KEY,
	LastName varchar(30) NOT NULL,
	FirstName varchar(30) NOT NULL,
	StoreID int FOREIGN KEY REFERENCES Stores(StoreID),
	Phone char(10),
	Email varchar (100),
	Address varchar(50),
	City varchar(50),
	State varchar(12)	
)

CREATE Table Products(
	ProductID int NOT NULL IDENTITY (3001, 1) PRIMARY KEY,
	Name varchar(50) NOT NULL,
	Type varchar(50),
	Brand varchar(50),
	Price money,
	Quantity int NOT NULL,
	CHECK (Quantity >= 0)
)

CREATE TABLE CustomerProducts(
	OrderID int NOT NULL IDENTITY (4001, 1) PRIMARY KEY,
	ProductID int NOT NULL FOREIGN KEY REFERENCES Products(ProductID),
	CustomerID int NOT NULL FOREIGN KEY REFERENCES Customers(CustomerID)
)

CREATE TABLE StoreProducts(
	StoreProduct int NOT NULL IDENTITY (5001, 1) PRIMARY KEY,
	StoreID int NOT NULL FOREIGN KEY REFERENCES Stores(StoreID),
	ProductID int NOT NULL FOREIGN KEY REFERENCES Products(ProductID),
	Inventory int NOT NULL
)

CREATE TABLE Orders(
	OrderID int NOT NULL IDENTITY (6001, 1) PRIMARY KEY,
	CustomerID int NOT NULL FOREIGN KEY REFERENCES Customers(CustomerID),
	ProductID int NOT NULL FOREIGN KEY REFERENCES Products(ProductID),
	StoreID int NOT NULL FOREIGN KEY REFERENCES Stores(StoreID),
	Date datetime DEFAULT GETDATE()
)

CREATE Table ProductOrders(
	ProductOrderID int NOT NULL IDENTITY (7001, 1) PRIMARY KEY,
	ProductID int NOT NULL FOREIGN KEY REFERENCES Products(ProductID),
	OrderID int NOT NULL FOREIGN KEY REFERENCES Orders(OrderID),
	Quantity int,
	CHECK (Quantity <= 10)
)

CREATE TABLE StoreManagers(
	StoreManagersID int NOT NULL IDENTITY (8001, 1) PRIMARY KEY,
	StoreID int NOT NULL FOREIGN KEY REFERENCES Stores(StoreID),
	ManagerID int NOT NULL FOREIGN KEY REFERENCES Managers(ManagerID)
)
