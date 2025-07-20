CREATE DATABASE eshift;
USE eshift;


CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL DEFAULT 'Customer',
    Phone NVARCHAR(20) NOT NULL,
    Address NVARCHAR(255) NOT NULL
);

CREATE TABLE Jobs (
    JobID INT IDENTITY(1,1) PRIMARY KEY,
    StartLocation NVARCHAR(255) NOT NULL,
    EndLocation NVARCHAR(255) NOT NULL,
    Status NVARCHAR(50) NOT NULL,
    Distance FLOAT,
    UserID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);


CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Category NVARCHAR(100) NOT NULL,
    Weight FLOAT NOT NULL,
    SpecialInstructions NVARCHAR(255)
);

CREATE TABLE Transport (
    TransportID INT IDENTITY(1,1) PRIMARY KEY,
    DriverName NVARCHAR(100) NOT NULL,
    Vehicle NVARCHAR(100) NOT NULL,
    VehicleNo NVARCHAR(50) NOT NULL UNIQUE,
    Availability NVARCHAR(20) NOT NULL CHECK (Availability IN ('Available', 'Not Available')),
    WeightCapacity FLOAT NOT NULL,
    PricePerKM DECIMAL(10, 2) NOT NULL
);
CREATE TABLE Jobs (
    JobID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    StartLocation NVARCHAR(255) NOT NULL,
    EndLocation NVARCHAR(255) NOT NULL,
    Status NVARCHAR(50) NOT NULL DEFAULT 'Pending',
    Distance FLOAT NOT NULL,
    TotalPrice DECIMAL(12, 2) NULL,
    Instruction NVARCHAR(500) NULL,         -- ✅ New column
    TransportID INT NULL,
    ProductID INT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (CustomerID) REFERENCES Users(UserID) ON DELETE CASCADE,
    FOREIGN KEY (TransportID) REFERENCES Transport(TransportID) ON DELETE SET NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE SET NULL
);