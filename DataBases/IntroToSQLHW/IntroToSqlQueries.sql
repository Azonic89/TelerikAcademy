-- 4.Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
SELECT d.DepartmentID, d.Name, d.ManagerID
FROM Departments d

/*SELECT * FROM Departments */


-- 5.Write a SQL query to find all department names.
SELECT d.Name
FROM Departments d


-- 6.Write a SQL query to find the salary of each employee.
SELECT CONCAT(e.FirstName, ' ', e.LastName, ' recieves $', e.Salary)
FROM Employees e


-- 7.Write a SQL to find the full name of each employee.
SELECT CONCAT(e.FirstName,' ', e.MiddleName, ' ', e.LastName) AS FullName
FROM Employees e


-- 8.Write a SQL query to find the email addresses of each employee (by his first and last name). 
-- Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". 
-- The produced column should be named "Full Email Addresses"
SELECT CONCAT(e.FirstName, '.', e.LastName, '@telerik.com') AS 'Email Address'
FROM Employees e 


-- 9.Write a SQL query to find all different employee salaries.
SELECT DISTINCT e.Salary
FROM Employees e


-- 10.Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
SELECT *
FROM Employees e
WHERE e.JobTitle = 'Sales Representative'  


-- 11.Write a SQL query to find the names of all employees whose first name starts with "SA".
SELECT CONCAT(e.FirstName, ' ', e.MiddleName, ' ', e.LastName) AS FullName
FROM Employees e
WHERE e.FirstName LIKE 'SA%'


-- 12.Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT CONCAT(e.FirstName, ' ', e.MiddleName, ' ', e.LastName) AS FullName
FROM Employees e
WHERE LastName LIKE '%ei%'


-- 13.Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
SELECT CONCAT(e.FirstName, ' ', e.MiddleName, ' ', e.LastName, e.Salary) AS 'FullName'
FROM Employees e
WHERE e.Salary >= 20000 AND e.Salary <= 30000
ORDER BY e.Salary ASC


-- 14.Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT CONCAT(e.FirstName, ' ', e.MiddleName, ' ', e.LastName, e.Salary) AS 'FullName'
FROM Employees e
WHERE e.Salary IN (25000, 14000, 125000, 23600)
ORDER BY e.Salary DESC


-- 15.Write a SQL query to find all employees that do not have manager.
SELECT e.FirstName, e.LastName, e.ManagerID
FROM Employees e
WHERE e.ManagerID IS NULL


-- 16.Write a SQL query to find all employees that have salary more than 50000. 
-- Order them in decreasing order by salary.
SELECT CONCAT(e.FirstName, ' ', e.LastName, ' ',  e.Salary ) AS FullName
FROM Employees e
WHERE e.Salary >= 50000
ORDER BY e.Salary DESC


-- 17.Write a SQL query to find the top 5 best paid employees.
SELECT TOP 5 CONCAT(e.FirstName, ' ', e.LastName, ' ', e.Salary) AS FullName
FROM Employees e
ORDER BY e.Salary DESC


-- 18.Write a SQL query to find all employees along with their address. 
-- Use inner join with ON clause.
SELECT e.EmployeeID, e.FirstName, e.LastName, a.AddressText, e.AddressID, a.AddressID
FROM Employees e
JOIN Addresses a
	ON e.AddressID = a.AddressID


-- 19.Write a SQL query to find all employees and their address. 
-- Use equijoins (conditions in the WHERE clause).
SELECT e.EmployeeID, e.FirstName, e.LastName, a.AddressText, e.AddressID, a.AddressID
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID


-- 20.Write a SQL query to find all employees along with their manager.
SELECT e.EmployeeID, CONCAT(e.FirstName, ' ', e.LastName) AS Employee,
       m.EmployeeID AS ManagerID, CONCAT(m.FirstName, ' ', m.LastName) AS Manager		
FROM Employees e
JOIN Employees m
	ON e.ManagerID = m.EmployeeID


-- 21.Write a SQL query to find all employees, along with their manager and their address. 
-- Join the 3 tables: Employees e, Employees m and Addresses a.
SELECT CONCAT(e.FirstName, ' ', e.LastName, '<--Address: ', a.AddressText, '-->') AS Employee,
	   CONCAT(p.FirstName, ' ', p.LastName) AS Manager
FROM Employees e
JOIN Employees p
	ON e.ManagerID = p.ManagerID
JOIN Addresses a
	ON e.AddressID = a.AddressID


-- 22.Write a SQL query to find all departments and all town names as a single list. Use UNION.
SELECT d.Name AS [Town--Department]
FROM Departments d
UNION
SELECT t.Name AS [Town--Department]
FROM Towns t


-- 23.Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. 
-- Use right outer join. 

SELECT CONCAT(e.FirstName, ' ', e.LastName) as Employee,
       CONCAT(m.FirstName, ' ', m.LastName) as Manager
FROM Employees m 
RIGHT JOIN Employees e
    ON e.ManagerID = m.EmployeeID

-- Rewrite the query to use left outer join.
SELECT CONCAT(e.FirstName, ' ', e.LastName) as Employee,
       CONCAT(m.FirstName, ' ', m.LastName) as Manager
FROM Employees e 
LEFT JOIN Employees m
    ON e.ManagerID = m.EmployeeID


-- 24.Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
SELECT CONCAT(e.FirstName, ' ', e.LastName, ' - ', d.Name, '<--', DATEPART(YEAR, e.HireDate), '-->')
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance')
	AND DATEPART(YEAR, e.HireDate) BETWEEN 1995 AND 2005

