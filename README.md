[![GitHub License](https://img.shields.io/github/license/gulceselim/re-cap-project-with-csharp?color=green)](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/LICENSE.txt)
![GitHub Repo stars](https://img.shields.io/github/stars/gulceselim/re-cap-project-with-csharp?color=yellow)
<!--![GitHub repo size](https://img.shields.io/github/repo-size/gulceselim/re-cap-project-with-csharp)-->

<h1 align="center">ReCap Project : Araba Kiralama Sistemi</h1> 

<p align="center">
  <img src="https://user-images.githubusercontent.com/43720773/106998466-9d31b280-6795-11eb-8e5b-16e0b78a99bc.PNG" width="600" alt="Rent A Car">
</p>

## ⭐ Introduction 
- **Entities, DataAccess, Business ve Console katmanlarından oluşan araba kiralama console projesidir. Şimdilik Car, Brand ve Color nesnelerinden ve onun operasyonlarından oluşan bu küçük proje zamanla geliştirilecektir.**
- **Bir önceki projemde N-Katmanlı Mimari yapısını kullanmıştım ve [README.md](https://github.com/gulceselim/ReCapDemo/blob/master/README.md) dosyasında elimden geldiğince açıklamaya çalışmıştım isterseniz bakabilirsiniz.**
- **[Sql query](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/RentACarSQLQuery.sql) dosyamı da ekledim isteyen varsa faydalanabilir.**


## Recent Changes
- Core katmanını dahil ederek buraya ekledeğimiz dosyalara, bu projedeki bütün katmanlar erişebilir. Aynı zamanda Core katmanındaki dosyaları başka projelerde de kullanabiliriz. 
- Core katmanına yazmış olduğumuz [EfEntityRepositoryBase](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs) dosyamızı ekleyerek DRY(Don't repeat yourself) prensibine uymuş olduk.
- Daha kullanışlı bir [arayüz](#output) tasarlandı.
- DTOs klasörü eklendi. 
- Car ile Color ve Brand modellerinin join işlemi yapıldı ve yeni bir model olan [CarDetailDto](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/DTOs/CarDetailDto.cs) nesnesi oluşturuldu.

## Table of Contents
- [Recent Changes](#recent-changes)
- [Installation](#installation)
- [Usage](#usage)
- [Layers](#layers)
- [SQL Query](#sql-query)
- [Tables in Database](#tables-in-database)
- [Output](#output)
- [Files](#files)
- [License](#license)


## Installation
Aşağıdaki paketler NuGet aracığıyla **DataAccess** katmanına eklenmelidir.
> - Microsoft.EntityFrameworkCore (3.1.11)
> - Microsoft.EntityFrameworkCore.SqlServer (3.1.11)

Aşağıdaki paket NuGet aracığıyla **Core** katmanına eklenmelidir.
> - Microsoft.EntityFrameworkCore.SqlServer (3.1.11)

## Usage 
Aşağıda görmüş olduğunuz resimdeki işlemi gerçekleştirdikten sonra Ctrl+F5 ile uygulamayı çalıştırabilirsiniz.

![Image for Usage](https://user-images.githubusercontent.com/43720773/107143179-aa40d400-6944-11eb-9a45-e3f6dcdf6b80.jpg)


## Layers
<table>
  <tr>
    <th>Entity Layer</th>
     <th>Business Layer</th>
     <th>Data Access Layer</th>
  </tr>
  <tr>
    <td>
      
Concrete | DTOs
------------ | -------------
[Car.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Car.cs) | [CarDetailDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/DTOs/CarDetailDto.cs)
[Brand.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Brand.cs)
[Color.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Color.cs)

   </td>
    <td>
  
Concrete | Abstract
------------ | -------------
[CarManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/CarManager.cs) | [ICarService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/ICarService.cs)
[BrandManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/BrandManager.cs) | [IBrandService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IBrandService.cs)
[ColorManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/ColorManager.cs) | [IColorService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IColorService.cs)

   </td>
    <td>
  
Concrete | Abstract
------------ | -------------
[EfCarDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfCarDal.cs) | [ICarDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/ICarDal.cs)
[EfBrandDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfBrandDal.cs) | [IBrandDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IBrandDal.cs)
[EfColorDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfColorDal.cs) | [IColorDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IColorDal.cs)
[RentACarContext.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Context/RentACarContext.cs)

   </td>
  </tr>
 </table>

<table>
  <tr>
    <th>Core Layer</th>
     <th>Presentation Layer</th>
  </tr>
  <tr>
  <td>
  
Entities | DataAccess
------------ | -------------
[IDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Entities/IDto.cs) | [IEntityRepository.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/DataAccess/IEntityRepository.cs)
[IEntity.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Entities/IEntity.cs) | [EfEntityRepositoryBase.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)
 
   </td>
   <td>
  
Console 
------------ 
[Program.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/ConsoleUI/Program.cs) 
 
   </td>
  </tr>
 </table>


## SQL Query
1. [RentACarSQLQuery.sql](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/RentACarSQLQuery.sql)


## Tables in Database
<table>
  <tr>
    <td>Cars</td>
     <td>Brands</td>
     <td>Colors</td>
  </tr>
  <tr>
    <td>

Variable Name | Data Type
------------ | -------------
CarId | int
BrandId | int
ColorId | int
ModelYear | string
DailyPrice | decimal
Description | string
   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
ColorId | int
ColorName | string
   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
BrandId | int
BrandName | string
   
   </td>
  </tr>
 </table>


## Output
![Console Output](https://user-images.githubusercontent.com/43720773/107492977-1c602580-6b9e-11eb-97f4-5081455063d0.jpg)


## Files
![Files](https://user-images.githubusercontent.com/43720773/107492995-241fca00-6b9e-11eb-8449-4280c692fe0f.jpg)


## License
[MIT](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/LICENSE.txt) © Selim Gulce
