create database org
use org

CREATE TABLE Students2024 (ID INT, Name VARCHAR(50));
INSERT INTO Students2024 VALUES
(1,'Ravi'),(2,'Asha'),(3,'John'),(4,'Meera'),(5,'Kiran'),
(6,'Divya'),(7,'Lokesh'),(8,'Anita'),(9,'Rahul'),(10,'Sneha');


CREATE TABLE Students2025 (ID INT, Name VARCHAR(50));
INSERT INTO Students2025 VALUES
(2,'Asha'),(4,'Meera'),(5,'Kiran'),(11,'Prakash'),(12,'Vidya'),
(13,'Neha'),(14,'Manoj'),(15,'Ramesh'),(16,'Lata'),(17,'Akash');


CREATE TABLE Employees (EmpID INT, Name VARCHAR(50), Department VARCHAR(20));
INSERT INTO Employees VALUES 
(1,'Ananya','HR'),(2,'Ravi','IT'),(3,'Meera','Finance'),
(4,'John','IT'),(5,'Divya','Marketing'),(6,'Sneha','Finance'),
(7,'Lokesh','HR'),(8,'Asha','IT'),(9,'Kiran','Finance'),(10,'Rahul','Sales');


CREATE TABLE Projects (ProjectID INT, Name VARCHAR(50), StartDate DATE, EndDate DATE);
INSERT INTO Projects VALUES 
(1,'Bank App','2025-01-01','2025-03-15'),
(2,'E-Commerce','2025-02-10','2025-05-20');


CREATE TABLE Contacts (ID INT, Name VARCHAR(50), Email VARCHAR(50), Phone VARCHAR(20));
INSERT INTO Contacts VALUES
(1,'Ravi','ravi@gmail.com',NULL),
(2,'Asha',NULL,'9876543210'),
(3,'John',NULL,NULL);

/* Task 1: 
Show a list of all student names (unique only).
Show a list of all student names (including duplicates). */
select name from Students2024 union select name from Students2025
select name from Students2024 union all select name from Students2025


/*Task 2:
1.Display employee names in UPPERCASE and LOWERCASE.
2.Find the length of each employee’s name.
3.Show only the first 3 letters of each name.
4.Replace Finance department with Accounts.
5.Create a new column showing "Name - Department" using CONCAT.*/
select upper(name) as Name_U, lower(name) as name_l from employees
select len(name) from employees
select substring(name, 1,3) from employees
select replace(department, 'Finance', 'Accounts') as departments from employees
select concat(name,'-',department) from employees


/*Task 3:
1.Show today’s date using GETDATE().
2.Find the duration (in days) of each project using DATEDIFF.
3.Add 10 days to each project’s EndDate using DATEADD.
4.Find how many days are left until each project ends. (Hint: Use DATEDIFF with GETDATE())*/
select getdate() as date_today
select ProjectId, datediff(day,StartDate,EndDate) as duration from projects
select dateadd(day,10, enddate) as EndDate_new from projects
select datediff(day, getdate(), enddate) from projects


/*Task 4:
1.Convert today’s date into DD/MM/YYYY format using CONVERT.
2.Convert a float 123.456 into an integer using CAST.*/
select convert(varchar(10),getdate(),103) as date_today
select cast(123.456 as int) as int_value