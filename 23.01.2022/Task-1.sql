--Database Yaradin Adi Ne Olursa Olsun
Create Database KompTelBaku
Use KompTelBaku

--Brands Adinda Table Yaradin 2 dene colum Id ve Name
Create Table Brands
(
	Id int primary key identity,
	Name nvarchar(30)
)

--Notebooks Adinda Table Yaradin Id,Name, Price Columlari Olsun.
Create Table Notebooks
(
	Id int primary key identity,
	Name nvarchar(30),
	Price money,
	--1) Notebook ve Brand Arasinda Mentiqe Uygun Relation Qurun.
	BrandId int references Brands(Id)
)

--Phones Adinda Table Yaradin Id, Name, Price Columlari Olsun.
Create Table Phones
(
	Id int primary key identity,
	Name nvarchar(30),
	Price money,
	--1) Phones ve Brand Arasinda Mentiqe Uygun Relation Qurun.
	BrandId int references Brands(Id)
)

--3) Notebooks Adini, Brandin Adini BrandName kimi ve Qiymetini Cixardan Query.
Select (Brands.Name+' '+Notebooks.Name) as [Brand Name], Notebooks.Price From Notebooks
Inner Join Brands on Brands.Id=Notebooks.BrandId

--4) Phones Adini, Brandin Adini BrandName kimi ve Qiymetini Cixardan Query.
Select (Brands.Name+' '+Phones.Name) as [Brand Name], Phones.Price From Phones
Inner Join Brands on Brands.Id=Phones.BrandId

--5) Brand Adinin Terkibinde s Olan Butun Notebooklari Cixardan Query.
Select Notebooks.Name, Notebooks.Price From Notebooks
Inner Join Brands on Brands.Id=Notebooks.BrandId Where Brands.Name Like('%s%')

--6) Qiymeti 2000 ve 5000 arasi ve ya 5000 den yuksek Notebooklari Cixardan Query.
Select Name, Price, BrandId From Notebooks where Price Between 2000 and 5000 or Price > 5000

--7) Qiymeti 1000 ve 1500 arasi ve ya 1500 den yuksek Phonelari Cixardan Query.
Select Name, Price, BrandId From Phones where Price Between 1000 and 1500 or Price > 1500

--8) Her Branda Aid Nece dene Notebook Varsa Brandin Adini Ve Yaninda Sayini Cixardan Query.
Select Brands.Name [Brands], Count( Brands.Name) [Count] From Notebooks
Inner Join Brands on Brands.Id=Notebooks.BrandId Group By Brands.Name

--9) Her Branda Aid Nece dene Phone Varsa Brandin Adini Ve Yaninda Sayini Cixardan Query.
Select Brands.Name [Brands], Count( Brands.Name) [Count] From Phones
Inner Join Brands on Brands.Id=Phones.BrandId Group By Brands.Name

--10) Hem Phone Hem de Notebookda Ortaq Olan Name ve BrandId Datalarni Bir Cedvelde Cixardan Query.
Select n.Name, n.BrandId  From Notebooks n 
Union All
Select p.Name, p.BrandId From Phones p 

--11) Phone ve Notebook da Id, Name, Price, ve BrandId Olan Butun Datalari Cixardan Query.
Select * From Notebooks n
Inner Join Phones p on n.BrandId=p.BrandId

--12) Phone ve Notebook da Id, Name, Price, ve Brandin Adini BrandName kimi Olan Butun Datalari Cixardan Query.
Select p.Id,p.Name,b.Name 'BrandName',p.Price from Phones p
Join Brands b
on p.BrandID=b.Id
Union
Select n.Id, n.Name,b.Name 'BrandName',n.Price from Notebooks n
Inner Join Brands b
on n.BrandID=b.Id
Order By BrandName

--13) Phone ve Notebook da Id, Name, Price, ve Brandin Adini BrandName kimi Olan Butun Datalarin Icinden Price 1000-den Boyuk Olan Datalari Cixardan Query.
Select tbl.Id,tbl.Name,tbl.Price,b.Name 'BrandName' From
(
Select p.Id, p.Name, p.Price,p.BrandID from Phones p
Union 
Select n.Id,n.Name,n.Price,n.BrandID From Notebooks n
)
as tbl
Inner Join Brands b
on tbl.BrandID=b.Id
Where tbl.Price>1000
Order By BrandID

--14) Phones Tabelenden Data Cixardacaqsiniz Amma Nece Olacaq 
--Brandin Adi (BrandName kimi), Hemin Brandda Olan Telefonlarin Pricenin Cemi 
--(TotalPrice Kimi) ve Hemin Branda Nece dene Telefon Varsa Sayini (ProductCount Kimi) 
--Olan Datalari Cixardan Query.
Select b.Name 'BrandName',Sum(p.Price) 'TotalPrice', Count(b.Name) 'ProductCount' from Brands b
Join Phones p
on b.Id=p.BrandID
Group by b.Name

--15) Notebooks Tabelenden Data Cixardacaqsiniz Amma Nece Olacaq Brandin Adi 
--(BrandName kimi), Hemin Brandda Olan Notebookslarin Pricenin Cemi 
--(TotalPrice Kimi) , Hemin Branda Nece dene Notebooks Varsa Sayini (ProductCount Kimi)
--Olacaq ve Sayi 3-ve 3-den Cox Olan Datalari Cixardan Query.
Select b.Name 'BrandName',Sum(p.Price) 'TotalPrice', Count(b.Name) 'ProductCount' from Brands b
Inner Join Notebooks p
on b.Id=p.BrandID
Group by b.Name
Having COUNT(b.Name)>3