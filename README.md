# Araç Kiralama Sistemi (Rent A Car System) 
<p align="center">
<img src="https://st2.depositphotos.com/2172301/6557/v/950/depositphotos_65575193-stock-illustration-vector-template-of-car-rental.jpg"  alt="Araç Kiralama Sistemi (Rent A Car System)" width="400" height="400"/>

![](https://img.shields.io/github/stars/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/forks/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/tag/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/release/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/issues/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/bower/v/editor.md.svg)

### *About*
- Bu proje, bir online eğitim platformu olan Kodloma.io'da Engin Demiroğ tarafından verilen "Yazılım Geliştirici Yetiştirme Kampı" için Tekrar ve geliştirme projesi (ReCapProject) olması amacıyla oluşturulmuştur. Proje, bir araba kiralama sistemi olup proje dili Türkçedir. 

- This project was created as a Recap project for "Software Developer Training Camp" given by Engin Demirog on Kodlama.io, an online education platform. The project is a car rental system and the project language is Turkish.
 
 
 <p> 
 <a href="https://www.kodlama.io/" target="_blank"> 
  <img src="https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/Zk7d1MdoSJ6cEShVbfd0" width="50" height="50"> Kodlama.io
  </a> &nbsp;


### *Kullanılan IDE* 
<p> 
 <a href="https://visualstudio.microsoft.com/tr/vs/" target="_blank"> 
<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Visual_Studio_Icon_2019.svg/1200px-Visual_Studio_Icon_2019.svg.png" width="50" height="50"> 
Visual Studio 2019
  </a> &nbsp;
 
### *Yüklenen Paketler*
- Microsoft.EntityFrameworkCore.SqlServer (3.1.11) --> Core katmanında olacak şekilde
```sql
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
```
  
  

