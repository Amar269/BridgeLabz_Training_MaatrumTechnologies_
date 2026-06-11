-- created the db 
create database Student_db;

-- use the db
use Student_db;

-- created the tables employees and stduent 
create table Student
(
  s_id int primary key identity(1,1) ,
  s_name varchar(50) not null,
  s_email varchar(50) not null unique,
);


create table employees
( 
  emp_id int primary key identity(101 ,1),
  emp_name varchar(50) not null,
  emp_email varchar(50) not null unique
);

-- select statements to view the data in the tables
select *from Student;

select * from employees;


-- stored procedure for the student and employee tables to view and delete the data 
-- created sp for view stduent 
create procedure s_viewstudent
@pstd_id int
as
begin

 select * from Student where s_id = @pstd_id;

end 

-- created the sp for the delete the student data 

create procedure s_deletestudent
@del_id int
as
begin

 delete  from Student where s_id = @del_id;

end 

-- cereated the sp for the view employee data 

create procedure emp_viewemployee
@emps_id int
as
begin

 select * from employees where emp_id = @emps_id;

end 

-- created the sp for the delete employee data

create procedure emp_deleteemployee
@emp_del_id int
as
begin

 delete  from employees where emp_id = @emp_del_id;

end 
