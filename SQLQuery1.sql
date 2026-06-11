CREATE DATABASE DEMO
USE DEMO
CREATE TABLE name(
id INT PRIMARY KEY,
name VARCHAR(50) NOT NULL,
age INT  
)

INSERT INTO name (id , name , age) VALUES(1,'Aamr' , 22);

SELECT * FROM name
