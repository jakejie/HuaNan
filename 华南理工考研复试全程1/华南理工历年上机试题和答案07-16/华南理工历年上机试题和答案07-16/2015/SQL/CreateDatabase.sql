Create database test2015
go
use test2015
go
create table EMPLOYEE
(
EmpNo char(6) not null,
EmpName varchar(50) not null,
EmpSex char(2) null,
EmpAge int  null,
constraint PK_EMPLOYEE primary key (EmpNo)
)
go
create table COMPANY
(
CmpNo char(6) not null,
CmpName varchar(50) not null,
constraint PK_COMPANY primary key(CmpNo)
)
go
create table WORKS
(
EmpNo char(6) not null,
CmpNo char(6) not null,
Salary Numeric(8,2) default (0),
constraint PK_WORKS primary key(EmpNo,CmpNo),
constraint FK_WORKS_EMPLOYEE foreign key(EmpNo) references EMPLOYEE(EmpNo),
constraint FK_WORKS_COMPANY foreign key(CmpNo) references COMPANY(CmpNo)
)
go
insert into EMPLOYEE values('E01','张三','女','32')
insert into EMPLOYEE values('E02','李四','男','28')
insert into EMPLOYEE values('E03','王五','女','42')
insert into EMPLOYEE values('E04','赵六','男','37')
insert into EMPLOYEE values('E05','陈七','男','51')
go
insert into Company values('C01','腾讯')
insert into Company values('C02','阿里')
insert into Company values('C03','百度')
go
insert into WORKS values('E01','C01','8000')
insert into WORKS values('E01','C02','7000')
insert into WORKS values('E02','C02','9000')
insert into WORKS values('E02','C03','8000')
insert into WORKS values('E03','C01','12000')
insert into WORKS values('E04','C02','11000')
insert into WORKS values('E05','C03','12000')
go