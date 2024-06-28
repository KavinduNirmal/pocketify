CREATE DATABASE Pocketify;

GO

USE Pocketify;

GO

-- Users Table
CREATE TABLE Users 
(
	UID INT IDENTITY(1,1),
	UserName VARCHAR(20) UNIQUE NOT NULL,
	Email VARCHAR(50) NOT NULL,
	PwdHash VARCHAR(256) NOT NULL,
	PRIMARY KEY(UID)
);


SELECT * FROM Users;

-- CategoryIcons Table
CREATE TABLE CategoryIcons (
    IconID INT IDENTITY(1,1) PRIMARY KEY,
    IconType VARCHAR(50) NOT NULL,
    IconPath VARCHAR(255) NOT NULL
);

-- Categories Table

CREATE TABLE Categories (
    CatID INT IDENTITY(1,1) PRIMARY KEY,
    UID INT,
    CategoryName VARCHAR(20) NOT NULL,
    CatAmount FLOAT NOT NULL,
    CategoryIcon INT,
    FOREIGN KEY (UID) REFERENCES Users(UID),
    FOREIGN KEY (CategoryIcon) REFERENCES CategoryIcons(IconID)
);

SELECT * FROM Categories;

-- Transactions Table
CREATE TABLE Transactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    UID INT,
    Date DATETIME NOT NULL,
    Title VARCHAR(30) NOT NULL,
    Description VARCHAR(255),
    Amount FLOAT NOT NULL,
    CategoryID INT,
    FOREIGN KEY (UID) REFERENCES Users(UID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CatID)
);

SELECT * FROM Transactions;

-- Balance Table

CREATE TABLE Balance (
    UID INT PRIMARY KEY,
    Balance FLOAT NOT NULL,
    BalanceGoal FLOAT,
    BalanceDeadLine DATE,
    FOREIGN KEY (UID) REFERENCES Users(UID)
);

SELECT * FROM Balance;

-- CreditBalance Table
CREATE TABLE CreditBalance (
    UID INT PRIMARY KEY,
    Balance FLOAT NOT NULL,
    FOREIGN KEY (UID) REFERENCES Users(UID)
);

SELECT * FROM CreditBalance;

-- Expenses Table
CREATE TABLE Expenses (
    ExpenseID INT IDENTITY(1,1) PRIMARY KEY,
    UID INT,
    Date DATETIME NOT NULL,
    TransactionID INT,
    Value FLOAT NOT NULL,
    FOREIGN KEY (UID) REFERENCES Users(UID),
    FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID)
);

SELECT * FROM Expenses;

-- Income Table
CREATE TABLE Income (
    IncomeID INT IDENTITY(1,1) PRIMARY KEY,
    UID INT,
    Date DATETIME NOT NULL,
    TransactionID INT,
    Value FLOAT NOT NULL,
    FOREIGN KEY (UID) REFERENCES Users(UID),
    FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID)
);

SELECT * FROM Income;