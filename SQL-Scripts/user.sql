USE [StarGroceriesDB]
GO
create table users(
userid int not null identity(1,1) primary key,
name varchar(255),
role varchar(255),
login varchar(255),
password varchar(255),
);

ALTER TABLE users
add updatedTime datetime default getdate()

select * from users


INSERT INTO users (name, role, login, password)
VALUES ('Admin', 'admin', 'admin', 'admin'),
('Sharmin', 'admin', 'sharmin', 'sharmin');

