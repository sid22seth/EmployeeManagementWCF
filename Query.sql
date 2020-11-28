create database EmployeeManagement
use EmployeeManagement
create table EmployeeDetails(
id int identity(1, 1),
Name varchar(50) not null,
Salary decimal not null,
Email varchar(50) not null
)
select*from EmployeeDetails