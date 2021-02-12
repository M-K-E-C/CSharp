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
select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID 
inner join Orders on  Orders.OrderId = od.OrderId

select*from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null

Select p.ProductName  ÜrünAdı, 
sum(od.Quantity*od.UnitPrice) KazanılanToplamMiktar  
From Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID
group by p.ProductName;

 select Products.ProductName UrunAdi, 
sum([Order Details].UnitPrice * [Order Details].Quantity) KazanilanPara 
from Products inner join [Order Details]
on Products.ProductID = [Order Details].ProductID inner join Orders
on Orders.OrderID = [Order Details].OrderID
group by Products.ProductName;