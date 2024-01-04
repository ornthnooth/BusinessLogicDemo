Home screen will have links/ actions to allow Primary Use Case actions.
Data entity model is given in PDF diagram.

Special consideration needs to be given for logic involving insufficient inventory for an order. Data model for transactions allows for backordering
through use of order date and execution date.

USE CASES
•	Add Product
•	Edit Product
•	Add Supplier
•	Stock Product
•	Sell Product
•	View Product stock
Secondary
•	Order Stock
•	Backorder Sale

**Priority CRUD actions

GetInventory
	@productNumber
	Returns qty

AddInventory 
	@productNumber
	@Qty

RemoveInventory
	@ProductNumber
	@Qty

Sell item
	GetTotalQty
	RemoveInventory(if enough)
	Create Transactions

OrderItem
	@date
	@item
	Addinventory
 
 IN LIEU of NET EF creation, SQL DATABASES could be created and linked.
		
		 CREATE TABLE Transactions(
			TransactionID varchar(255)NOT NULL PRIMARY KEY,
			Product ID int NOT NULL,
			Count int,
			Type varchar(255),
			RequestDate DateTime,
			ExecuteDate DateTime
		);
		
		CREATE TABLE Inventory(
			ID int NOT NULL PRIMARY KEY,
			ProductID int,
			Count int
		);
		
		CREATE TABLE Products(
			ProductID int NOT NULL PRIMARY KEY,
			Name varchar(255),
			Price decimal,
			SupplierID int
		);
		
		CREATE TABLE Suppliers(
			SupplierID int NOT NULL PRIMARY KEY,
			SupplierName varchar(255),
			Address varchar(255),
			Email varchar(255),
			Phone varchar(255)
		);
		
		SELECT Products.ProductID, Supplier.SupplierName, Supplier.Email
		FROM Products
		INNER JOIN Suppliers ON Product.SupplierID = Suppliers.SupplierID;
		
		SELECT Products.ProductID, Product.ProductName, Inventory.Count
		FROM Inventory
		INNER JOIN Product ON Inventory.ProductID = Product.ProductID
		--WHERE conditions
		 ;
![image](https://github.com/ornthnooth/BusinessLogicDemo/assets/15217454/551c349a-8617-425f-a85c-a6f9d270796c)
