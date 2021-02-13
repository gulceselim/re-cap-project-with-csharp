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
✔ [Results](https://github.com/gulceselim/re-cap-project-with-csharp/tree/main/Core/Utilities/Results) klasörü core katmanında oluşturuldu ve bütün Business Sınıfları buna yapıya göre refactor edildi. <br>
✔ [Message.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Constants/Messages.cs) static class'ı oluşturuldu ve yapılan işlemlerde dönücek mesajlar bu class'a yazıldı. <br>
✔ Customer, Rental, User tabloları eklendi. Bu modeller için CRUD operasyonları eklendi. [RentACarSQLQuery.sql](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/RentACarSQLQuery.sql) <br>
✔ Araba kiralarken, arabanın teslim edilmiş mi edilmemiş mi? Bunun [kontrolü](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/RentalManager.cs) yapıldı. <br>

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
Aşağıdaki paketler NuGet aracığıyla **DataAccess** katmanına eklenmelidir. <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `Microsoft.EntityFrameworkCore (3.1.11)` <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `Microsoft.EntityFrameworkCore.SqlServer (3.1.11)` <br>

Aşağıdaki paket NuGet aracığıyla **Core** katmanına eklenmelidir. <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📦 `Microsoft.EntityFrameworkCore.SqlServer (3.1.11)` <br>

## Usage 
Aşağıda görmüş olduğunuz resimdeki işlemi gerçekleştirdikten sonra Ctrl+F5 ile uygulamayı çalıştırabilirsiniz.

![Image for Usage](https://user-images.githubusercontent.com/43720773/107143179-aa40d400-6944-11eb-9a45-e3f6dcdf6b80.jpg)


## Layers
🗃 **``Entities Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Car.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Car.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Brand.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Brand.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Color.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Color.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Customer.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Customer.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Rental.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Rental.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [User.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/User.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DTOs`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarDetailDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/DTOs/CarDetailDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalDetailDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/DTOs/RentalDetailDto.cs) <br><br>

🗃 **``Business Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/CarManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BrandManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/BrandManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ColorManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/ColorManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CustomerManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/CustomerManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/RentalManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/UserManager.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICarService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/ICarService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IBrandService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IBrandService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IColorService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IColorService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICustomerService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/ICustomerService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IRentalService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IRentalService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUserService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IUserService.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Constants`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Messages.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Constants/Messages.cs) <br><br>

🗃 **``Data Access Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Context`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [RentACarContext.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Context/RentACarContext.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Repository`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfCarDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfCarDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfBrandDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfBrandDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfColorDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfColorDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfCustomerDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfCustomerDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfRentalDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfRentalDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfUserDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfUserDal.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICarDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/ICarDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IBrandDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IBrandDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IColorDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IColorDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICustomerDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/ICustomerDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IRentalDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IRentalDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUserDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IUserDal.cs) <br>



🗃 **``Core Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Entities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Entities/IDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEntity.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Entities/IEntity.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DataAccess`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEntityRepository.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/DataAccess/IEntityRepository.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [EfEntityRepositoryBase.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Utilities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Results`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IDataResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/IDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [DataResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/DataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SuccessDataResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/SuccessDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ErrorDataResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/ErrorDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/IResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Result.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/Result.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SuccessResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/SuccessResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ErrorResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/ErrorResult.cs) <br><br>

🗃 **``Presentation Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Program.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/ConsoleUI/Program.cs)<br>

## SQL Query
&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentACarSQLQuery.sql](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/RentACarSQLQuery.sql)


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
<img src="https://user-images.githubusercontent.com/43720773/107849881-381e3280-6e0f-11eb-848d-14c5fc54a4e9.jpg" alt="Console Output"></img>


## Files
<p align="center">
  <img src="https://user-images.githubusercontent.com/43720773/107849882-38b6c900-6e0f-11eb-99dd-63cfd1c04e9f.jpg"></img>
  <img src="https://user-images.githubusercontent.com/43720773/107849884-39e7f600-6e0f-11eb-826a-ddb89f129cc1.jpg"></img>
</p>


## License
[MIT](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/LICENSE.txt) © Selim Gulce
