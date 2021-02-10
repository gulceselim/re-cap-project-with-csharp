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
- Artık projemiz bir memory üzerinde değil, database üzerinde çalışıyor ✔
- EntityFramework dosyaları eklendi ✔
- [Brand](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/BrandManager.cs) ve [Car](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/CarManager.cs) modelleri için bazı kısıtlamalar yapıldı✔ (İlgili modelin üzerine tıklayarak ulaşabilirsiniz.)


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
Aşağıdaki paketler NuGet aracığıyla DataAccess katmanına eklenmelidir.
> - Microsoft.EntityFrameworkCore (3.1.11)
> - Microsoft.EntityFrameworkCore.SqlServer (3.1.11)


## Usage 
Aşağıda görmüş olduğunuz resimdeki işlemi gerçekleştirdikten sonra Ctrl+F5 ile uygulamayı çalıştırabilirsiniz.

![Image for Usage](https://user-images.githubusercontent.com/43720773/107143179-aa40d400-6944-11eb-9a45-e3f6dcdf6b80.jpg)


## Layers
<table>
  <tr>
    <th>Entities Layer</th>
     <th>Business Layer</th>
     <th>Data Access Layer</th>
     <th>Presentation Layer</th>
  </tr>
  <tr>
    <td>
      
Concrete | Abstract
------------ | -------------
[Car.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Car.cs) | [IEntity.cs](https://github.com/gulceselim/re-cap-project-with-csharp/tree/main/Entities/Abstract)
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
[RentACarContext.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Context/RentACarContext.cs) | [IEntityRepository.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IEntityRepository.cs)

   </td>
    <td>
  
Concrete | Abstract
------------ | -------------
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
![Console Output](https://user-images.githubusercontent.com/43720773/106929084-fca3aa00-6724-11eb-877c-8f66c0a7f6d9.jpg)


## Files
![Files](https://user-images.githubusercontent.com/43720773/106918756-8bf79000-671a-11eb-9b60-4e20d46ed1d8.jpg)


## License
[MIT](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/LICENSE.txt) © Selim Gulce
