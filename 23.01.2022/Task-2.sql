--Kitabxana database-i qurursunuz
Create Database Kitabxana
Use Kitabxana

--Books (Id, Name, PageCount)
Create Table Books
(
	[Id] int Primary Key Identity,
	--Books-un Name columu minimum 2 simvol maksimum 100 simvol deyer ala bileceyi serti olsun.
	[Name] nvarchar(30) Check(len (Name) Between 2 And 100),
	--Books-un PageCount columu minimum 10 deyerini ala bileceyi serti olsun.
	[PageCount] int Check(PageCount >= 10),
	--Books ve Authors table-larinizin mentiqi uygun elaqesi olsun.
	[AuthorId] int references Authors(Id)
)

--Authors (Id, Name, Surname)
Create Table Authors
(
	[Id] int Primary Key Identity,
	[Name] nvarchar(30),
	[SurName] nvarchar(30)
)

--Kitab Elave Olunmasi
Insert Into Books (Name,PageCount,AuthorId)
Values
('Kicik Qehreman',200,1),
('Gozel Bahar',230,1),
('Araz',170,1),
('Dilenci Qadinin Sirri',220,2),
('Qan Lekesi',190,2),
('Sofinin Dunyasi',240,3),
('Kukla Ustasi',205,3),
('Babamin Bavulu',215,4),
('Sessiz Ev',225,4)

--Muellifin Elave Olunmasi.
Insert Into Authors 
Values
('Abdulla','Saiq'),
('Elxan','Elatli'),
('Jostein','Gaarder'),
('Orhan','Pamuk')

--Id, Name, PageCount ve AuthorFullName columnlarinin valuelarini qaytaran bir view yaradin
Create View usv_GetBooksAndAuthorName
As
Select b.Id, b.Name, b.PageCount ,(a.Name+' '+a.SurName)'AuthorFullName' From Books b
Inner Join Authors a on b.AuthorId=a.Id

--Gonderilmis axtaris deyirene gore hemin axtaris deyeri name ve ya authorFullNamelerinde olan Book-lari 
--Id, Name, PageCount, AuthorFullName columnlari seklinde gostern procedure yazin.
Create Procedure usp_SearchAllBooksByString (@Values nvarchar(30))
As
Begin
Select b.Id,b.Name,b.PageCount,(a.Name+' '+a.Surname) 'AuthorFullName' from Books b
Inner Join Authors a
on b.AuthorId=a.Id
Where b.Name like '%'+@Values+'%'or a.Name like '%'+@Values+'%' or a.Surname like '%'+@Values+'%'
End

--Authors tableinin insert, update ve deleti ucun (her biri ucun ayrica) procedure yaradin
--Muellifin Elave Olunmasi.
Create Procedure usp_InsertAuthorsData(@Name nvarchar(30),@SurName nvarchar(30))
AS
Begin
Insert Into Authors(Name,SurName)
Values (@Name,@SurName)
End

--Muellifin Adinda ve Soyadinda Deyisiklik.
Create Procedure usp_UpdateAuthorsDataById
(@AuthorId int,@Name nvarchar(30),@SurName nvarchar(30))
As
begin
Update Authors
set Name=@Name,Surname=@SurName
where Id=@AuthorId
END

--Muellifin Silinmesi.
Create Procedure usp_DeleteAuthors (@Name nvarchar(30),@SurName nvarchar(30))
As
Begin
Delete Authors Where Authors.Name=@Name And Authors.SurName=@SurName
End

--Authors-lari Id,FullName,BooksCount,MaxPageCount seklinde qaytaran view yaradirsiniz.
--Id-author id-si,
--FullName - Name ve Surname birlesmesi, 
--BooksCount - Hemin authorun elaqeli oldugu kitablarin sayi, 
--MaxPageCount - hemin authorun elaqeli oldugu kitablarin icerisindeki max pagecount deyeri.
Create View usv_GetAllBooks
As
Select a.Id,(a.Name+' '+a.SurName) 'FullName',
Count((a.Name+' '+a.SurName)) 'BooksCount' ,
MAX(b.PageCount) 'MaxPageCount' 
from Authors a
Inner Join Books b
on a.Id=b.AuthorId
group by (a.Name+' '+a.Surname),a.Id


