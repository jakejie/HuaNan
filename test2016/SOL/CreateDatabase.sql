create database test2016
go
use test2016
create table Department(
			DeptNo char(6) not null,
			DeptName varchar(20) not null
			constraint PK_Department primary key(DeptNo)
)
go
create table Class(
			CNo char(6) not null,
			SpecName varchar(20) not null,
			Num int check(Num<=30),
			CYear char(4),
			DeptNo char(6) not null
			constraint PK_Class primary key(CNo)
			constraint FK_Class_Department foreign key(DeptNo) references Department(DeptNo),
			UNIQUE(CNO,SpecName)
)
go

create table Student(
			SNo char(6) not null,
			SName varchar(20) not null,
			SDate date null,
			CNo char(6) not null,
			constraint PK_Student primary key(SNo),
			constraint FK_Student_Class foreign key(CNo) references Class(CNo) on delete cascade
)
go

insert into Department values('1','数学')
insert into Department values('2','计算机')
insert into Department values('3','化学')
go

insert into Class values('101','微计算机','23','2011','2')
insert into Class values('102','人工智能','24','2012','2')
insert into Class values('103','无机化学','19','2011','3')
insert into Class values('104','数理统计','20','2012','1')
insert into Class values('105','有机化学','21','2013','3')
insert into Class values('106','智能算法','23','2011','2')
go

insert into Student values('8101','张三','1995-4-5','101')
insert into Student values('8102','李四','1996-5-12','103')
insert into Student values('8103','张飞','1995-5-7','105')
insert into Student values('8104','周瑜','1993-4-15','106')
insert into Student values('8105','王五','1992-11-06','102')
insert into Student values('8106','王飞','1993-12-09','104')
insert into Student values('8107','李牛','1992-5-8','105')
insert into Student values('8108','张全蛋','1996-5-7','101')
insert into Student values('8109','李小花','1995-6-8','103')
insert into Student values('8110','赵铁柱','1994-8-9','102')