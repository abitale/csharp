CREATE DATABASE db_bank;

USE db_bank;

CREATE TABLE offices(
officeCode INT NOT NULL IDENTITY(1,1) ,
city VARCHAR(20),
phone VARCHAR(18),
addressLine1 TEXT,
addressLine2 TEXT,
state varchar(20),
country VARCHAR(20),
postalCode VARCHAR(6),
territory VARCHAR(20),
PRIMARY KEY(officeCode),
);

CREATE TABLE employees(
employeeNumber INT NOT NULL IDENTITY(1,1),
lastName VARCHAR(30) NOT NULL,
firstName VARCHAR(30) NOT NULL,
extension INT,
email VARCHAR(30) NOT NULL,
officeCode INT NOT NULL,
reportsTo INT,
jobTitle VARCHAR(30),
PRIMARY KEY(employeeNumber),
FOREIGN KEY(officeCode)REFERENCES offices(officeCode),
FOREIGN KEY(reportsTo)REFERENCES employees(employeeNumber)
);

CREATE TABLE customers(
customerNumber INT NOT NULL IDENTITY(1,1),
customerName VARCHAR(30) NOT NULL,
contactLastName VARCHAR(30) NOT NULL,
contactFirstName VARCHAR(30) NOT NULL,
phone VARCHAR(18),
addressLine1 TEXT NOT NULL,
addressLine2 TEXT,
city varchar(20),
state VARCHAR(20),
postalCode INT,
country VARCHAR(20),
salesRepEmployeeNumber INT,
creditLimit INT,
PRIMARY KEY(customerNumber),
FOREIGN KEY(salesRepEmployeeNumber)REFERENCES employees(employeeNumber)
);


CREATE TABLE productlines(
productLine INT NOT NULL IDENTITY(1,1),
textDescription TEXT,
htmlDescription TEXT,
image TEXT,
PRIMARY KEY(productLine)
);

CREATE TABLE products(
productCode INT NOT NULL IDENTITY(1,1),
productName VARCHAR(30),
productLine INT,
productScale INT,
productVendor VARCHAR(30),
productDescription TEXT,
quantityInStock INT,
buyPrice INT,
MSRP INT,
PRIMARY KEY(productCode),
FOREIGN KEY(productLine)REFERENCES productlines(productLine)
);

CREATE TABLE orders(
orderNumber INT NOT NULL IDENTITY(1,1),
orderDate DATE,
requiredDate DATE,
shippedDate DATE,
orderStatus INT,
comments VARCHAR(200),
customerNumber INT,
PRIMARY KEY(orderNumber),
FOREIGN KEY(customerNumber)REFERENCES customers(customerNumber)
);

CREATE TABLE orderdetails(
orderNumber INT NOT NULL,
productCode INT NOT NULL,
quantityOrdered INT,
priceEach INT,
orderLineNumber INT,
FOREIGN KEY(orderNumber)REFERENCES orders(orderNumber),
FOREIGN KEY(productCode)REFERENCES products(productCode)
);

CREATE TABLE payments(
customerNumber INT NOT NULL,
checkNumber INT NOT NULL,
paymentDate DATE,
amount INT,
PRIMARY KEY(checkNumber)
);

INSERT INTO offices VALUES(
'Bandung','02493281','Jln.Pekanbaru','','Jawa Barat','Indonesia','50134','Durian'
);

INSERT INTO employees VALUES(
'Kusuma','Bekti',5,'kusuma@yahoo.com',1,NULL,'Head Unit'
);

INSERT INTO employees VALUES(
'Jaya','Bagus',6,'bagus@yahoo.com',1,4,'Officer'
);

INSERT INTO customers VALUES(
'Agung Setiakawan','Setiakawan','Agung','08324219457','Jln.Madukara II','','Bandung','Jawa Barat','50135','Indonesia',6,5000000
);

INSERT INTO productlines VALUES(
'Toyota Super','Toyota','./assets/mobil_toyota.png'
);

INSERT INTO products VALUES(
'Mobil Toyota',1, 3,'Toyota Astra','new Toyota Mobil 2021', 5, 98000000, 80000000
);

INSERT INTO orders VALUES(
'2022-03-23','2022-03-26','2022-03-24',1,'',1
);

INSERT INTO orderdetails VALUES(
1,1,1,98000000,1
);

INSERT INTO payments VALUES(
1,142,'2022-03-23',98000000
);

SELECT * FROM offices;

SELECT * FROM employees;

SELECT * FROM customers;

SELECT * FROM productlines;

SELECT * FROM products;

SELECT * FROM orders;

SELECT * FROM orderdetails;

SELECT * FROM payments a FULL JOIN customers b ON a.customerNumber=b.customerNumber;

SELECT a.customerName,a.phone,a.addressLine1,b.firstName,b.jobTitle FROM customers a INNER JOIN employees b ON a.salesRepEmployeeNumber=b.employeeNumber;

SELECT * from orders a LEFT JOIN orderdetails b ON a.orderNumber=b.orderNumber RIGHT JOIN products c ON b.productCode=c.productCode;