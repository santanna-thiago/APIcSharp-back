CREATE TABLE domain_type (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(255) NOT NULL,
);

CREATE TABLE domain_status (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(255) NOT NULL,
);

CREATE TABLE customers (
    Id int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(255) NOT NULL,
    Cpf bigint UNIQUE NOT NULL,
    Gender varchar(255) NOT NULL,
    Domain_Status_Id int NOT NULL FOREIGN KEY REFERENCES domain_status(Id),
    Domain_Type_Id int NOT NULL FOREIGN KEY REFERENCES domain_type(Id),
    Created_At DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL ,
    Updated_At DATETIME DEFAULT NULL
);

