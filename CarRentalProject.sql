CREATE TABLE Cars (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NULL,
    [BrandId]      INT           NULL,
    [ColorId]      INT           NULL,
    [DailyPrice]   DECIMAL (18)  NULL,
    [ModelYear]    INT           NULL,
    [Descriptions] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ColorId]) REFERENCES Colors([Id]),
    FOREIGN KEY ([BrandId]) REFERENCES Brands([Id])
);

CREATE TABLE Colors (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (25) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)

);

CREATE TABLE Brands (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (25) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


create table Users(
 [Id]   INT           IDENTITY (1, 1) NOT NULL,
 [FirstName] varchar(50) NOT NULL,
 [LastName] varchar(50) NOT NULL,
 [Email] varchar(100) NOT NULL,
 [Password] varchar(16) NOT NULL,
 PRIMARY KEY CLUSTERED ([Id] ASC),
 FOREIGN KEY ([Id]) REFERENCES Customers([UserId]),
  
 );

 create table Customers(
 [UserId] INT IDENTITY (1, 1) NOT NULL,
 [CompanyName] varchar(45) NULL
 PRIMARY KEY CLUSTERED ([UserId] ASC),
 
   
 );

 create table Rentals(
 [Id] INT IDENTITY (1,1) NOT NULL,
 [CarId] INT NOT NULL,
 [CustomerId] INT NOT NULL,
 [RentDate] INT NOT NULL,
 [ReturnDate] INT NULL,
 PRIMARY KEY CLUSTERED ([Id] ASC),
 FOREIGN KEY ([CarId]) REFERENCES Cars([Id]),
 FOREIGN KEY ([CustomerId]) REFERENCES Customers([UserId]),

 );
