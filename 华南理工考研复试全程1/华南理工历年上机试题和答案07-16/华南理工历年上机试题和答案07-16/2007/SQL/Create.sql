create database test2007;
go
use test2007
go
create table Employee
(
EmpID char(6) not null,
EmpName varchar(50) null,
Salary int null,
DeptID char(6) not null,
constraint PK_Employee primary key(EmpID)
)
go
create table Department
(
DeptID char(6) not null,
DeptName varchar(50) null,
EmpID char(6) not null,
constraint PK_Department primary key(DeptID)
)
go

create trigger Update_Employee_Salary
on Employee
for Update
AS
if UPDATE(Salary)
print '不允许修改Salary的值'
rollback

--插入数据
insert into Employee values('E01','张三','5000','D01')
insert into Employee values('E02','李四','5700','D01')
insert into Employee values('E03','王五','8000','D02')
insert into Employee values('E04','赵六','10000','D03')
insert into Employee values('E05','韩琦','8500','D04')
insert into Employee values('E06','刘八','6000','D01')
go
insert into Department values('D01','事业部','E01')
insert into Department values('D02','广告部','E03')
insert into Department values('D03','研发部','E04')
insert into Department values('D04','市场部','E05')
go

