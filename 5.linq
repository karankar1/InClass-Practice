<Query Kind="Expression">
  <Connection>
    <ID>78c5d23d-2221-474f-b75a-e5d0aeebc531</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>NorthwindExtended</Database>
  </Connection>
</Query>


from person in Employees
where person.FirstName.Contains("an")
select person

