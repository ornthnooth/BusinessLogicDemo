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
![image](https://github.com/ornthnooth/BusinessLogicDemo/assets/15217454/551c349a-8617-425f-a85c-a6f9d270796c)
