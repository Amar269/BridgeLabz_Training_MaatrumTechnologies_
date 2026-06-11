-- The following queries are used to know exsiting databses 
EXEC SP_databases
SELECT name FROM sys.databases

-- to create a db
CREATE DATABASE school_db

-- LETS THINK WE HAVE TWO OR MORE DB and we wnat to know on which databse the operitons are going to work at present
USE school_db
USE demo
SELECT DB_NAME() -- so when i try to execute the use and next execute this query i can know which db

-- creating a table in school_db
CREATE TABLE students (
student_id INT ,
name VARCHAR(50),
age INT,
city VARCHAR(50)
);

-- CHEKING EXSTING TBALE
EXEC sp_help 'students'

-- Insert the data into tables

INSERT INTO students VALUES(1,'Amarnath' , 22 ,'BZA');
INSERT INTO students VALUES(2,'Kolla' , 21 ,'TYTP');
INSERT INTO students VALUES(2,'Aditya' , 20 ,'BZA'); -- have to delet added dupicted data .
INSERT INTO students VALUES(3,'Aditya' , 20 ,'BZA');
INSERT INTO students VALUES(4,'MSD' , 45 ,'CSK');

-- Reading data form the table

SELECT * FROM students -- to read full table 

SELECT name FROM students -- to read only speccifc coloum 

-- Update the data in table 
UPDATE students 
SET name = 'MS Dhoni'
WHERE student_id = 4;

-- delete the data from table

DELETE FROM students 
WHERE name = 'Aditya' AND studnet_id = 2;


-- Rename the column
EXEC sp_rename 'dbo.students.studnet_id', 'student_id', 'COLUMN';

-- excerise code 1. update the city name of id -4 
UPDATE students 
SET city = 'Ranchi'
WHERE student_id = 4;

-- 2nd question add new staudetn deatails 

INSERT INTO students VALUES(5,'Hari' , 18 ,'Hyd');
SELECT * FROM students
ORDER BY student_id;

-- 3rd question print only the age of students 
SELECT age  FROM students


-- CREATING A NEW TBALE OF employees

CREATE TABLE employees(
emp_id INT PRIMARY KEY IDENTITY(101 , 1),
F_name  VARCHAR(50) NOT NULL ,
L_name VARCHAR(50) NOT NULL ,
Email VARCHAR(100) NOT NULL UNIQUE,
Job_Title VARCHAR(50) NOT NULL ,
DEPT VARCHAR(50),
SALARY INT DEFAULT 30000,
City_name VARCHAR(100),
Hire_date DATETIME DEFAULT GETDATE()
)

SELECT *FROM employees

INSERT INTO employees VALUES ('AMARNATH' , 'KOLLA' , 'ak4909@srmist.edu.in' , '.NET DEVELOPER' , 'IT' , 40000 , 'BZA' , DEFAULT)
INSERT INTO employees VALUES ('ADITYA' , ' KOLLA' , 'aV4459@srmist.edu.in' , 'CLOUD ENG' , 'IT' , 400000 , 'TPTY' , DEFAULT)
INSERT INTO employees VALUES ('MSD' , 'INDIA' , 'Thalaforaresaon@gmail.com' , 'BATTER' , 'CRICEKT' , 40000000 , 'RANCHI' , DEFAULT)
INSERT INTO employees VALUES ('NTR' , 'TFI' , 'NTROFFICAL@gmial.com' , 'Actor' , 'movies' , 4000000 , 'hyd' , DEFAULT)
INSERT INTO employees VALUES ('Aarav', 'Sharma', 'aarav.sharma@example.com', 'Director', 'Management', 180000, 'Mumbai' , DEFAULT)
INSERT INTO employees VALUES ('Diya', 'Patel', 'diya.patel@example.com', 'Lead Engineer', 'Tech', 120000,  'Bengaluru' , DEFAULT)
INSERT INTO employees VALUES('Rohan', 'Mehra', 'rohan.mehra@example.com', 'Software Engineer', 'Tech', 85000,  'Bengaluru' , DEFAULT)
INSERT INTO employees VALUES('Priya', 'Singh', 'priya.singh@example.com', 'HR Manager', 'Human Resources', 95000,  'Mumbai' , DEFAULT)
INSERT INTO employees VALUES('Arjun', 'Kumar', 'arjun.kumar@example.com', 'Data Scientist', 'Tech', 110000, 'Hyderabad', DEFAULT)
INSERT INTO employees VALUES('Ananya', 'Gupta', 'ananya.gupta@example.com', 'Marketing Lead', 'Marketing', 90000, 'Delhi',  DEFAULT)


SELECT  DEPT FROM employees;

-- using LIKE operator to find the data.

SELECT * FROM employees WHERE F_name  LIKE '%A%'


-- TOP 
SELECT TOP 2* FROM employees ORDER BY SALARY ;


-- using CASE 

SELECT 
   F_name,
   L_name,
   SALARY,

CASE 
    WHEN SALARY > 100000 THEN 'HIGH SALARUY'
    WHEN SALARY BETWEEN 60000 AND 100000 THEN 'MEDIUM SALARY'
    ELSE 'LOW SALARY'
    END AS salary_band
FROM 
   employees;



---- Aggregrate Functions

SELECT COUNT(emp_id) FROM employees;
SELECT MIN(SALARY) FROM employees;
SELECT MAX(SALARY) FROM employees;
SELECT AVG(SALARY) FROM employees;


--- Group BY 
SELECT DEPT,COUNT(emp_id) as COUNT FROM employees GROUP BY DEPT;

 
 --- multi level grouping 
 SELECT DEPT , city_name , COUNT (emp_id) as COUNT FROM employees GROUP BY DEPT,city_name
 ORDER BY COUNT DESC;


-- having caluse 

SELECT Job_Title , AVG (SALARY) FROM employees GROUP BY Job_Title

SELECT DEPT , COUNT(emp_id) as COUNT FROM employees GROUP BY DEPT


-- ROOLUP 
SELECT DEPT,SUM(SALARY) as TOTAL_SALARY FROM employees GROUP BY ROLLUP(DEPT)

-- question on the rollup like want to know headcount of by city and dept 
SELECT DEPT, COALESCE(city_name ,'Total') AS city_name, COUNT(emp_id) FROM employees 
GROUP BY ROLLUP(DEPT , city_name) ORDER BY DEPT;


SELECT *from employees where SALARY <= (SELECT AVG (SALARY) from employees)

SELECT AVG (SALARY) from employees


-- string functions ---

-- concat
SELECT CONCAT (F_name, ' ' , L_name) AS Full_Name FROM employees


select datediff (month , '2025-07-31' , getdate())


-- ALTER THE TBALE (ADD , DROP OR MODIFIY ) --
alter table employees
add phone varchar(15);

select * from employees

alter table employees
drop column phone;


---- CTE ---- 
WITH avg_salary as(
select DEPT  , AVG (SALARY) AS AVG_DEPT  
FROM employees GROUP BY DEPT , SALARY )

select  e.F_name , e.DEPT , e.SALARY , a.AVG_DEPT
FROM employees e join avg_salary a 
on e.DEPT = a.DEPT