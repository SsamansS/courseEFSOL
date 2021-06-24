--create database MyDB

--вывод инвормации о БД
execute sp_helpdb MyDB;

--подключаемся к БД MyDB
use MyDB;


GO
CREATE TABLE EmloyeesAndPhones
(
	ID int identity primary key NOT NULL,   
	Employee nvarchar NOT NULL,
	Phone int NOT NULL
)
GO
GO
CREATE TABLE SalaryAndPosition
(
	ID int identity primary key NOT NULL,
	Salary money NOT NULL,
	Position varchar NOT NULL,
	EmployeeID int foreign key references EmloyeesAndPhones(ID) NOT NULL
)
GO
GO
CREATE TABLE ExtraInfo
(
	ID int identity primary key NOT NULL,
	Married nchar NOT NULL,
	DateOfBirth date NOT NULL,
	Residence text NOT NULL,
	EmployeeID int foreign key references EmloyeesAndPhones(ID) NOT NULL

)
GO

