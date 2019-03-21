create database test2008
go
use test2008 
go
create table Department
(
DeptID char(6) not null,
DeptName varchar(50) null,
constraint PK_Department primary key(DeptID)
)
go
create table Class
(
ClassNo char(6) not null,
ClassName varchar(50) null,
AllNum int null check(AllNum<=30),
DeptID char(6) null,
constraint PK_Class primary key(ClassNo),
)
go
create table Student
(
SNo char(8) not null,
SName varchar(50) not null,
sex char(2) null,
ClassNo char(6) null,
constraint PK_Student primary key(SNo),
)
go
alter table Student
add constraint FK_Student_Class foreign key(ClassNo) references Class(ClassNo) on delete cascade 
alter table Class
add constraint FK_Class_Department foreign key(DeptID) references Department(DeptID) on delete cascade 
go
insert into Department values('D01','理学院')
insert into Department values('D02','经管学院')
insert into Department values('D03','体育学院')
insert into Department values('D04','信息学院')
insert into Department values('D05','软件学院')
go

insert into Class values('C01','信息与计算科学','28','D01')
insert into Class values('C02','光电信息','27','D01')
insert into Class values('C03','软件一班','22','D05')
insert into Class values('C04','计算机科学','26','D04')
insert into Class values('C05','会计一班','28','D02')
insert into Class values('C06','体育一班','16','D03')
insert into Class values('C07','软件二班','25','D05')
go
insert into Student values('S01','张三','男','C01')
insert into Student values('S02','张三','女','C04')
insert into Student values('S03','张三','男','C05')
insert into Student values('S04','张三','男','C06')
insert into Student values('S05','张三','男','C07')
insert into Student values('S06','张三','女','C03')
insert into Student values('S07','张三','女','C02')
insert into Student values('S08','张三','男','C04')
insert into Student values('S09','张三','女','C02')
insert into Student values('S10','张三','男','C03')
insert into Student values('S11','张三','男','C01')
insert into Student values('S12','张三','女','C07')
insert into Student values('S13','张三','男','C05')
insert into Student values('S14','张三','女','C06')
insert into Student values('S15','张三','男','C02')
insert into Student values('S17','张三','女','C01')
insert into Student values('S18','张三','男','C04')
insert into Student values('S19','张三','男','C03')
insert into Student values('S20','张三','女','C06')
insert into Student values('S21','张三','男','C07')
go

Alter table student
ADD column JoinYear char(4) 