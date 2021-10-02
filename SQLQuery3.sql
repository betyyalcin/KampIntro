--(-- çizgi yorum satırı)
--ANSII (Bütün veri tabanlarında çalışır.)

Select  ContactName Adi , CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City='Berlin'

select* from Products where categoryID=1 and UnitPrice>=10

select* from Products order by CategoryID,ProductName
select* from Products order by UnitPrice desc --fiyatı en pahalıdan en düşüğe 
select * from Products order by UnitPrice asc --fiyatı en düşükten en pahalıya

select COUNT (*) from Products where CategoryID=2 

select CategoryID, COUNT(*) from Products group by CategoryID -- her grup için kaç tane kategoryID ye denk gelen ürün varsa onu listeleer.

select CategoryID, COUNT(*) from Products group by CategoryID having count(*)<10 -- kategoriId'leri 10dan küçük bütün kategorileri listele

select CategoryID, COUNT(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10 --önce her zaman where çalışır. birim fiyatı 20den fazla olan ürünleri  kategori id ye göre grupla o grupta 10dan az olan kategroid leri listele.


 select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName  
 from Products inner join Categories on  Products.CategoryID = Categories.CategoryID
 where Products.UnitPrice>10-- product tablosundan productid, productname,productunitprice ve categori tablosundan kategoriname i getir.

 --DTO Data Transformation object

select * from Products p 
left join [Order Details] od on p.ProductID = od.ProductID -- p(product), od(orderdetails)

select * from Customers c left join 
Orders o on c.CustomerID= o.CustomerID 
where o.CustomerID is null -- solda olup siparişte olmayanları da getir. hiç ürün almamış olanlara indirim uygulaması yapılacak olan komut. "is null" komutu primary keylere uygulanır.
