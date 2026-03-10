CREATE TABLE employee2(
	employee_id INT PRIMARY KEY,
	name VARCHAR(100) NOT NULL,
	position VARCHAR(50),
	department VARCHAR(50),
	hired_date DATE,
	salary NUMERIC(10,2)
);

SELECT * FROM employee2;


INSERT INTO employee2 (employee_id,name,position,department,hired_date,salary)
	Values(101,'Lohith',' Manager','Accounting','2025-03-15',100000.00),
	(102,'Manoj','Supervisor','IT','2025-05-11',40000.00),
	(103,'Abhi','Data Analyst','IT','2025-07-26',35000.00),
	(104,'Suraj','Accountant','Finance','2025-10-13',20000.00),
	(105,'Suman','Sales Executive','Finance','2025-02-02',25000.00);


DELETE FROM employee2
WHERE department='Accounting';


DROP COLUMN salary;

ALTER TABLE employee2
DROP COLUMN salary;