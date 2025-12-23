
--create table employees
CREATE TABLE Employees (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Salary DECIMAL(10,2) NOT NULL,
    Department_Id INT NOT NULL,
);

--create table departments
CREATE TABLE Departments (
     ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);


--Add Foreign key

ALTER TABLE Employees
ADD CONSTRAINT FK_Employees_Departments
FOREIGN KEY (Department_Id)
REFERENCES Departments(ID);

--Table customers
CREATE TABLE Customers (
    ID NVARCHAR(10) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Address NVARCHAR(150) NOT NULL
);

CREATE TABLE Orders (
    ID NVARCHAR(10) PRIMARY KEY, 
    Customer_Id NVARCHAR(10) NOT NULL,
    Product_Id INT,  -- will add FK later
    Amount DECIMAL(10,3) NOT NULL
);

CREATE TABLE Products (
    ID INT IDENTITY(100,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Cost DECIMAL(10,3) NOT NULL
);


ALTER TABLE Orders
ADD CONSTRAINT FK_Orders_Products
FOREIGN KEY (Product_Id)
REFERENCES Products(ID);

ALTER TABLE Orders
ADD CONSTRAINT FK_Orders_Customers
FOREIGN KEY (Customer_Id)
REFERENCES Customers(ID);
