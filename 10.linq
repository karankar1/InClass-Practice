<Query Kind="Expression">
  <Connection>
    <ID>78c5d23d-2221-474f-b75a-e5d0aeebc531</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>NorthwindExtended</Database>
  </Connection>
</Query>

from row in Orders
select new 
//Initialization List - GOogle this 
{
Company = row.Customer.CompanyName,
COntact = row.Customer.ContactName,
Items = from item in row.OrderDetails
        select new
	{
	ProductNames = item.Product.ProductName,
	item.UnitPrice,
	item.Quantity,
	item.Discount,
	Total = item.UnitPrice * item.Quantity  // todo: apply  a discount
	
	}

}