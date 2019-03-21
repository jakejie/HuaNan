Create database test2014
go
use test2014
go
create table TEACHERS
(
TNo char(6) not null,
TName varchar(50) not null,
Dept varchar(50) null,
ReNo char(6) not null,
constraint PK_TEACHERS primary key (TNo)
)
go
Create table REMUNERATIONS
(
ReNo char(6) not null,
Salary Numeric(8,2) not null,
Constraint PK_REMUNERATIONS primary key(ReNo)
)
go
create table COURSES
(
CNo char(6) not null,
CName varchar(50) not null,
CTime int null,
TNo char(6) not null,
constraint PK_COURSES primary key(CNo),
constraint FK_COURSES_TEACHERS foreign key(TNo) references TEACHERS(TNo)
)
go
insert into TEACHERS values('T01','张三','计算机','Z01')
insert into TEACHERS values('T02','李四','物理','Z02')
insert into TEACHERS values('T03','王五','数学','Z02')
insert into TEACHERS values('T04','赵六','计算机','Z03')
go
insert into REMUNERATIONS values('Z01','80')
insert into REMUNERATIONS values('Z02','60')
insert into REMUNERATIONS values('Z03','40')
go
insert into COURSES values('C01','数据库','64','T01')
insert into COURSES values('C02','大学物理','56','T02')
insert into COURSES values('C03','高等数学','80','T03')
insert into COURSES values('C04','操作系统','60','T04')
insert into COURSES values('C05','线性代数','50','T03')
insert into COURSES values('C06','微积分','48','T03')
insert into COURSES values('C07','数据结构','60','T04')
go
