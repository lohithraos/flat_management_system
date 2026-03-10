CREATE TABLE employee(
	employee_id SERIAL PRIMARY KEY,
	name VARCHAR(100) NOT NULL,
	position VARCHAR(50),
	department VARCHAR(50),
	hired_date DATE,
	salary NUMERIC(10,2)
);

SELECT * FROM employee;


INSERT INTO employee(name,position,department,hired_date,salary)
	Values('Lohith',' Manager','Accounting','2025-03-15',100000.00),
	('Manoj','Supervisor','IT','2025-05-11',40000.00),
	('Abhi','Data Analyst','IT','2025-07-26',35000.00),
	('Suraj','Accountant','Finance','2025-10-13',20000.00),
	('Suman','Sales Executive','Finance','2025-02-02',25000.00);


	TRUNCATE TABLE employee;
