create database test2009
go
use test2009
go
create table Orders
(
OrderID	char(5) not null,
OrderName	varchar(30) not null,
OrderDate smalldatetime not null,
RequiredDate smalldatetime null,
Amount Numeric(12,2) default (0) for [Amount],
constraint PK_Orders primary key(OrderID)
)
go
create table Product
(
ProductID char(5) not null,
ProductName varchar(50) not null,
SupplierName varchar(50) not null,
constraint PK_Product primary key(ProductID)
)
create table OrderDetails
(
OrderID char(5) not null,
ProductID char(5) not null,
UnitPrice Numeric(8,2) not null,
Quantity Smallint not null,
constraint PK_OrderDetails primary key(OrderID,ProductID),
constraint fk_orderID foreign key(OrderID) references Orders(OrderID),
constraint fk_productID foreign key(ProductID) references Product(ProductID)
)
go
create index idx_ordername on Orders(OrderName)
go
create view vw_statistics
as
select ProductID,sum(Quantity) 销售数量,SUM(Quantity*UnitPrice) 销售金额
from OrderDetails
group by ProductID
go


