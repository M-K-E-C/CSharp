--Select
SELECT * FROM Customers;
Select contactName Adi,CompanyName Şirketadi,City Şehir from Customers
Select * From Products;

Select * from Customers where City = 'London'

select * from Products where categoryId = 1 or CategoryID =3

select * from Products where categoryId = 1 and UnitPrice>=10

select * from Products order by CategoryID,ProductName

select* from Products order by UnitPrice 

select* from Products order by UnitPrice desc

select* from Products where CategoryId =1 order by UnitPrice desc

select count(*) from Products

select categoryId from Products group by CategoryID

select categoryId,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

--DTO Data Tranformation object
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

select*from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null