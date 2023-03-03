create table Employee(
	Id int primary key identity,
	[Name] nvarchar(50),
	Gender char,
	Dob Datetime2,
	Contact nvarchar(40),
	DepartmentId int,
	FOREIGN KEY (DepartmentId) REFERENCES Department(Id)
);

create table Department(
	Id int primary key identity,
	[Name] nvarchar(50),
	[Description] nvarchar(200)
);

select * from Employee

--INSERT INTO Employee
--VALUES ('Gita Basnet', 'M', '1990/12/12', '98343234234')

update Employee set Gender='F'
where Id=3

delete from Employee where Id=2
