create DATABASE Books;


create table BookTable
(
BookId int primary key identity(1000,1),
Title varchar(100) NOT NULL,
BookPrice int,
AuthorId int,
foreign key (AuthorId) references Authors(AuthorId)
);

create table Authors
(
AuthorId int primary key identity(1000,1),
AuthorName varchar(255) NOT NULL,
);