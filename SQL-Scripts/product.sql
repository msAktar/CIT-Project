USE [StarGroceriesDB]
GO
create table Product
(productId int not null identity(1,1) primary key,
categoryId int FOREIGN KEY REFERENCES category(categoryId),
 price decimal(19,2),
 imageUrl varchar(25) Not Null,
 quantity int,
 size decimal,
 unitType varchar(5),
 special  BIT default 'FALSE',
 isDeleted  BIT default 'FALSE',
 deletedTime datetime default getdate(),
 modifiedTime datetime default getdate(),
 modifiedBy int,
);
select * from Product;