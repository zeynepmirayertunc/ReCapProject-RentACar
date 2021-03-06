# Araç Kiralama Sistemi (Car Rental System) 
<p align="center">
<img src="https://st2.depositphotos.com/2172301/6557/v/950/depositphotos_65575193-stock-illustration-vector-template-of-car-rental.jpg"  alt="Araç Kiralama Sistemi (Rent A Car System)" width="400" height="400"/>

![](https://img.shields.io/github/stars/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/forks/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/tag/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/release/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/issues/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/bower/v/editor.md.svg)

### *About*
- Bu proje, bir online eğitim platformu olan Kodloma.io'da [Engin Demiroğ](https://github.com/engindemirog) tarafından verilen "Yazılım Geliştirici Yetiştirme Kampı" için Tekrar ve geliştirme projesi (ReCapProject) olması amacıyla oluşturulmuştur. Proje, bir araba kiralama sistemi olup proje dili Türkçedir. 

- This project was created as a Recap project for "Software Developer Training Camp" given by [Engin Demirog](https://github.com/engindemirog) on Kodlama.io, an online education platform. The project is a car rental system and the project language is Turkish.
  
 
 <p> 
 <a href="https://www.kodlama.io/" target="_blank"> 
  <img src="https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/Zk7d1MdoSJ6cEShVbfd0" width="50" height="50"> Kodlama.io
  </a> &nbsp;

-----------------------
### *IDE* 
<p> 
 <a href="https://visualstudio.microsoft.com/tr/vs/" target="_blank"> 
<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Visual_Studio_Icon_2019.svg/1200px-Visual_Studio_Icon_2019.svg.png" width="25" height="25"> 
Visual Studio 2019
  </a> &nbsp;
 
----------------------------------------
### *Packages*
- Microsoft.EntityFrameworkCore.SqlServer (3.1.11) -- [Core katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) olacak şekilde
- Autofac(6.1.0) -- [Business katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) ve [Core katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) olacak şekilde
- Autofac.Extras.DynamicProxy(6.0.0) -- [Business katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) ve [Core katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) olacak şekilde
- FluentValidation(9.5.1) -- [Business katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) ve [Core katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) olacak şekilde
- Autofac.Extensions.DependencyInjection(7.1.0) -- [Core katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) olacak şekilde


---------------------------------------
### *SQL*
- Sql tablosu oluşturmak için --  [CarRentalProject.sql](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/CarRentalProject.sql)

<table>
<tr><th>Cars</th><th>Colors</th><th>Brands</th></tr>
<tr><td>

| Name  | Data type  |
|-------|-------------|
| Id      | INT  |                 
| Name    | NVARCHAR(50)  |                                                           
| BrandId      | INT     |
| ColorId      | INT   |
| DailyPrice    | DECIMAL |
| ModelYear      | INT |
| Descriptions   | NVARCHAR(50) |

</td><td>
 
| Name       | Data type  |  
|------------|--------------|
| Id      | INT    |
| Name    | NVARCHAR(50) |

</td><td>
 
| Name       | Data type  |  
|------------|--------------|
| Id      | INT    |
| Name    | NVARCHAR(50) |

</td></tr> </table>

<table>
<tr><th>Users</th><th>Customers</th><th>Rentals</th></th>
<tr><td>

| Name  | Data type  |
|-------|-------------|
| Id      | INT  |                 
| FirstName    | NVARCHAR(50)  |
| LastName    | NVARCHAR(50)  |
| Email    | NVARCHAR(100)  | 
| Password   | NVARCHAR(16)  | 

</td><td>
 
| Name       | Data type  |  
|------------|--------------|
| UserId      | INT    |
| CompanyName    | NVARCHAR(45) |

</td><td>
 
| Name       | Data type  |  
|------------|--------------|
| Id      | INT    |
| CarId      | INT    |
| CustomerId      | INT    |
| RentDate     | DATETIME    |
| ReturnDate    | DATETIME |


</td></tr> </table>

<table>
<tr><th>CarImages</th></tr>
<tr><td>
  
| Name       | Data type  |  
|------------|--------------|
| Id      | INT    |
| CarId      | INT    |
| ImagePath      | VARCHAR(max)    |
| Date     | DATETIME    |


</td></tr> </table>




-----------------------------------


### *Updates*
- 16.02.2021 -- [WebAPI katmanı](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/WebAPI) kuruldu :heavy_check_mark:
- 16.02.2021 -- [Business katmanındaki tüm servislerin](https://github.com/zeynepmirayertunc/ReCapProject/tree/master/Business/Abstract) [Api karşılığı](https://github.com/zeynepmirayertunc/ReCapProject/tree/master/WebAPI/Controllers) yazıldı :heavy_check_mark:
- 23.02.2021 -- Autofac desteği eklendi :heavy_check_mark:
- 23.02.2021 -- FluentValidation desteği eklendi :heavy_check_mark:
- 23.02.2021 -- AOP desteği eklendi :heavy_check_mark: 
- 26.02.2021 -- CarImages tablosu oluşturuldu :heavy_check_mark:
- 26.02.2021 -- Api üzerinden [arabaya resim ekleyecek sistem](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/WebAPI/Controllers/CarImagesController.cs) yazıldı :heavy_check_mark:

![arabaeklendi](https://user-images.githubusercontent.com/69868488/109347202-d4225200-7883-11eb-98a8-adb780d61b46.png)


- 26.02.2021 -- Resimler proje içerisindeki [klasördedir](https://github.com/zeynepmirayertunc/ReCapProject/tree/master/WebAPI/wwwroot/Images) :heavy_check_mark:
- 26.02.2021 -- Bir arabanın en fazla 5 resmi olabilmesi şartı eklendi :heavy_check_mark:

![uyarı](https://user-images.githubusercontent.com/69868488/109347342-1186df80-7884-11eb-8cae-c5ff39f55915.png)



- 26.02.2021 -- Resmin eklendiği tarihin sistem tarafından atanması işlemi gerçekleştirildi :heavy_check_mark:

- 26.02.2021 -- Bir arabaya ait resimlerin listeleme işlemi yapıldı :heavy_check_mark:

![getimages](https://user-images.githubusercontent.com/69868488/109347374-25324600-7884-11eb-896c-fd7494027116.png)


- 26.02.2021 -- Eğer bir arabaya ait resim yoksa, default bir resim gösterme işlemleri yazıldı :heavy_check_mark:

![resimbulunamadı](https://user-images.githubusercontent.com/69868488/109347426-38451600-7884-11eb-9e03-28bf81e6bdb1.png)
  
  
- 03.03.2021 --  JWT entegrasyonu gerçekleştirildi :heavy_check_mark:
- 06.03.2021 -- [Cache, Transaction ve Performance](https://github.com/zeynepmirayertunc/ReCapProject-RentACar/tree/master/Core/Aspects/Autofac) aspectleri eklendi :heavy_check_mark:
 
