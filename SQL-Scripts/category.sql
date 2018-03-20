create table category(
categoryId int not null identity(1,1) primary key,
categoryName varchar(255) not null,
subCategoryName varchar(255),
);

select * from category;

INSERT INTO category ( categoryName, subCategoryName)
VALUES ('Rice', 'Brown Rice'),
('Rice', 'Perboil Rice'),
('Rice', 'Basmoti Rice');
INSERT INTO category ( categoryName, subCategoryName)
VALUES ('Oil', 'Cooking Oil'),
('Oil', 'Coconut Oil'),
('Oil', 'Musturd Oil');