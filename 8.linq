<Query Kind="Expression">
  <Connection>
    <ID>78c5d23d-2221-474f-b75a-e5d0aeebc531</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>NorthwindExtended</Database>
  </Connection>
</Query>

from person in Employees
where person.EmployeeTerritories.Count >=4
// without a class name it is Anonymous Type
select new  //Person
{
ID = person.EmployeeID,
FullNAme = person.LastName + " , " + person.FirstName

}