create database InfiniteDB

use InfiniteDB

drop table department

create table Department(Deptid int primary key,DeptName varchar(30) not null,DeptBudget float)

select * from Department

--insert some rows into Department

insert into Department values(2,'HR',15000),(4,'Operations',20000),
(6,'Accounts',10000),(3,'Admin',50000),(5,'Testing',12000)

select * from Department

--update some values in the table

update Department set DeptBudget=75000 where Deptid=2

select * from Department

--sp_help Department;

drop table Employee

create table Employee
(EmpId int not null,
EmpName varchar(50)not null,
Gender char(7),
Salary decimal,
DepartmentId int references Department(deptid)
)

select * from 