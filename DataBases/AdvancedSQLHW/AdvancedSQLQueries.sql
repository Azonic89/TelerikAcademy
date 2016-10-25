--- 1. Write a SQL query to find the names and salaries of the 
--- employees that take the minimal salary in the company. 
--- Use a nested SELECT statement.
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS FullName, e.Salary AS Salary
FROM Employees e
WHERE e.Salary = (SELECT MIN(Salary) FROM Employees)


--- 2. Write a SQL query to find the names and salaries 
--- of the employees that have a salary that is up to 
--- 10% higher than the minimal salary for the company.
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS FullName, e.Salary AS Salary
FROM Employees e
WHERE e.Salary > (SELECT (MIN(Salary) + MIN(Salary) * 0.1) FROM Employees)
ORDER BY Salary


--- 3. Write a SQL query to find the full name, salary and 
--- department of the employees that take the minimal salary 
--- in their department. Use a nested SELECT statement.
SELECT CONCAT(e.FirstName, ' ', e.LastName), e.Salary, d.Name
FROM Employees e 
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE Salary =
    (SELECT MIN(Salary) FROM Employees m
    WHERE m.DepartmentID = d.DepartmentID)
ORDER BY Salary


--- 4. Write a SQL query to find the average salary in the department #1.
SELECT ROUND(AVG(e.Salary), 2) AS AverageSalary
FROM Employees e
WHERE e.DepartmentID = '1'


--- 5. Write a SQL query to find the average salary in the "Sales" department.
SELECT ROUND(AVG(e.Salary), 2) AS [AvgSal/Department]
FROM Employees e 
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'


--- 6. Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(e.EmployeeID) AS NumOfEmployees
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
