<Query Kind="Statements" />

//from char letter in "Karan Kumar"
//select letter
string[] names = {"karan","kumar","Riya"};
names.Dump();
var result = from item in names
select item;
result.Dump(); 