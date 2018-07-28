create database mybank;
use mybank;

create table Customer
(
	customerId int not null identity(1,1),
	customerFName varchar(50),
	customerLName varchar(50),
	customerAddress varchar(50),
	customerGender char,
	customerDOB date,
	customerPhone varchar(25),
	customerACNo int,
	customerPin int,
	customerBalance float,
	constraint pk_Customer primary key(customerId)
);
select * from Customer;

create table Transactions
(
	transactionId int not null identity,
	customerId int,
	transactionDate date default getdate(),
	transactionStatus varchar(15),
	transactionAmount float,
	constraint fk_Transaction_Customer foreign key(customerId) references Customer,
	constraint pk_Transaction primary key(transactionId, customerId)
);
select * from Transactions;