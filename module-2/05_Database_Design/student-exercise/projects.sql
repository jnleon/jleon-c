USE master;
GO

DROP DATABASE IF EXISTS ProjectOrganizer
GO

CREATE DATABASE ProjectOrganizer
GO

USE ProjectOrganizer 
GO

BEGIN TRANSACTION

CREATE TABLE department
(	
dept_numb						int	 identity (1,1),		
dept_name						varchar(15) not null,
num_employees_department		bigint not null,

	constraint pk_department primary key (dept_numb),
)
CREATE TABLE employee
(	
employee_id			int  identity (1,1),
jobtitle			varchar(15) not null,		
last_name			varchar(30) not null,		
first_name			varchar(15) not null,
gender				varchar(10) not null,
date_birth			Date not null,
date_hire			Date not null,
dept_numb			int not null,

constraint pk_employee primary key (employee_id),
	constraint fk_employee foreign key (dept_numb) references department (dept_numb)
)

CREATE TABLE project
(	
project_numb					int identity (1,1),		
project_name					varchar(15) not null,
project_start_date				Date not null,
num_employees_project			bigint not null,

constraint pk_project_numb	 primary key (project_numb),

)

CREATE TABLE project_employee
(
employee_Id		 int not null,
project_num		int not null,	

constraint pk_employee_Id	primary key (employee_Id, project_num),
constraint fk_project_num foreign key (project_num) references project (project_numb),
constraint fk_employee_Id foreign key (employee_Id) references employee (employee_id),

)

INSERT INTO department(dept_name,num_employees_department) 
VALUES ('Chuck E. Cheese ',2),
		('TESLA PR ',2),
		('Clean My Room',2),
		('Scam me Online',4)

INSERT INTO employee(jobtitle,last_name,first_name,gender,date_birth,date_hire, dept_numb)
VALUES ('HungryGuy', 'Marks', 'Matthew', 'male', '11-6-2001','2-3-2020',1),
		('HungryGuy2', 'Remon', 'Javier', 'male', '7-20-2000','2-3-2020',1),
		('CEO', 'Musk', 'Elon', 'male', '10-16-2020','10-16-2020',2),
		('CTO', 'uhm', 'X Æ A-12,', 'male', '10-16-2020','10-16-2020',2),
		('Dad', 'Francisco', 'Juan', 'male', '2-8-1976','7-19-2001',3),
		('Girlfriend', 'Hunziker', 'Eva', 'female', '10-14-1999','7-19-2019',3), 
		('Scammer1', 'Lu', 'Li', 'female', '1-1-1001','1-1-1001',4),
		('Scammer2', 'Ananda', 'Mohan', 'male', '1-1-1001','1-1-1001',4),
		('Scammer3', 'Leo', 'Marke', 'male', '1-1-1001','1-1-1001',4),
		('Scammer4', 'Marie', 'Emilia', 'female', '1-1-1001','1-1-1001',4)



INSERT INTO	project(project_name,project_start_date,num_employees_project)
VALUES('cleaning_piano', '10-16-2020', 1), 
		('cleaning_toilet', '10-16-2020', 1),
		('cleaning_tree', '10-16-2020', 1),
		('cleaning_bath', '10-16-2020', 1)


INSERT INTO project_employee(employee_Id,project_num)
VALUES (1,1), 
		(2,2),
		(3,3),
		(4,4)



COMMIT TRANSACTION