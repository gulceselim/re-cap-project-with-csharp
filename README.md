[![GitHub License](https://img.shields.io/github/license/gulceselim/re-cap-project-with-csharp?color=green)](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/LICENSE.txt)
![GitHub Repo stars](https://img.shields.io/github/stars/gulceselim/re-cap-project-with-csharp?color=yellow)
![GitHub repo size](https://img.shields.io/github/repo-size/gulceselim/re-cap-project-with-csharp)

<h1 align="center">ReCap Project : Araba Kiralama Sistemi</h1> 

<p align="center">
  <img src="https://user-images.githubusercontent.com/43720773/106998466-9d31b280-6795-11eb-8e5b-16e0b78a99bc.PNG" width="600" alt="Rent A Car">
</p>

## ⭐ Introduction 
- **Entities, DataAccess, Business, Core ve WebAPI katmanlarından oluşan araba kiralama projesidir. Bu projede Katmanlı mimari yapısı ve SOLID prensiplerine dikkate alınarak yazılmıştır. JWT entegrasyonu; Transaction, Cache, Validation ve Performance aspect'lerinin implementasyonu gerçekleştirilmiştir.** 
- **Validation için FluentValidation desteği, IoC için ise Autofac desteği eklenmiştir.**
- **[Sql query](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/RentACarSQLQuery.sql) dosyamı da ekledim isteyen varsa faydalanabilir.**


## Recent Changes
✔ Caching, Transaction ve Performance aspectleri eklendi. <br>
✔ CarManager class'ına ait olan GetAll metoduna Logging aspect'i eklendi. <br>
✔ Car nesnesinin GetAll metodu performance ile test edildi. <br>
✔ Çalıştırılan metodlar log4net.config ile log.json dosyasına yazıldı. <br> 

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
```bash
# Clone to repository
$ git clone https://github.com/gulceselim/re-cap-project-with-csharp.git

# Go to the folder you cloned
$ cd re-cap-project-with-csharp

# Install dependencies
$ dotnet restore
```

## Usage 
Aşağıda görmüş olduğunuz resimdeki işlemi gerçekleştirdikten sonra Ctrl+F5 ile uygulamayı çalıştırabilirsiniz. Daha sonrasında Postman uygulaması aracılığıyla projeye isteklerde bulunabilirsiniz. 

![Image for Usage](https://user-images.githubusercontent.com/43720773/110237438-28e15f00-7f4d-11eb-9305-4c9257a06e72.jpg)


## Layers
🗃 **``Entities Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Brand.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Brand.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Car.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Car.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarImage.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/CarImage.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Color.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Color.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Customer.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Customer.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Rental.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Rental.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DTOs`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarDetailDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/DTOs/CarDetailDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalDetailDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/DTOs/RentalDetailDto.cs) <br><br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserForLoginDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/DTOs/UserForLoginDto.cs) <br><br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserForRegisterDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/DTOs/UserForRegisterDto.cs) <br><br>

🗃 **``Business Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IAuthService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IAuthService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IBrandService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IBrandService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICarImageService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/ICarImageService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICarService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/ICarService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IColorService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IColorService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICustomerService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/ICustomerService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IRentalService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IRentalService.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUserService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IUserService.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``BusinessAspect`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SecuredOperation.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/BusinessAspect/Autofac/SecuredOperation.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AuthManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/AuthManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BrandManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/BrandManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarImageManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/CarImageManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/CarManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ColorManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/ColorManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CustomerManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/CustomerManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/RentalManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/UserManager.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Constants`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Messages.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Constants/Messages.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``DependencyResolvers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AutofacBusinessModule.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``ValidationRules`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``FluentValidation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BrandValidator.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/ValidationRules/FluentValidation/BrandValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarValidator.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/ValidationRules/FluentValidation/CarValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ColorValidator.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/ValidationRules/FluentValidation/ColorValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CustomerValidator.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/ValidationRules/FluentValidation/CustomerValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalValidator.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/ValidationRules/FluentValidation/RentalValidator.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserValidator.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/ValidationRules/FluentValidation/UserValidator.cs) <br><br>


🗃 **``Data Access Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Abstract`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IBrandDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IBrandDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICarImageDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/ICarImageDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICarDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/ICarDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IColorDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IColorDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICustomerDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/ICustomerDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IRentalDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IRentalDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IUserDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IUserDal.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Context`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [RentACarContext.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Context/RentACarContext.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 ``Repository`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfBrandDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfBrandDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfCarImageDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfCarImageDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfCarDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfCarDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfColorDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfColorDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfCustomerDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfCustomerDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfRentalDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfRentalDal.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  📃 [EfUserDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/EntityFramework/Repository/EfUserDal.cs) <br><br>


🗃 **``Core Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Aspect`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Autofac`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Caching`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CacheAspect.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Aspects/Autofac/Caching/CacheAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CacheRemoveAspect.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Aspects/Autofac/Caching/CacheRemoveAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Expection`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ExceptionLogAspect.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Aspects/Autofac/Expection/ExceptionLogAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Logging`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [LogAspect.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Aspects/Autofac/Logging/LogAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Performance`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [PerformanceAspect.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Aspects/Autofac/Performance/PerformanceAspect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Transaction`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [TransactionScopeAscpect.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Aspects/Autofac/Transaction/TransactionScopeAscpect.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Validation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ValidationAspect.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Aspects/Autofac/Validation/ValidationAspect.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``CrossCuttingConcerns`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Caching`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ICacheManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/CrossCuttingConcerns/Caching/ICacheManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Microsoft`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [MemoryCacheManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/CrossCuttingConcerns/Caching/Microsoft/MemoryCacheManager.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Logging`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [LogDetail.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/CrossCuttingConcerns/Logging/LogDetail.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [LogDetailWithException.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/CrossCuttingConcerns/Logging/LogDetailWithException.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [LogParameter.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/CrossCuttingConcerns/Logging/LogParameter.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Log4Net`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [LoggerServiceBase.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/CrossCuttingConcerns/Logging/Log4Net/LoggerServiceBase.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [SerializableLogEvent.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/CrossCuttingConcerns/Logging/Log4Net/SerializableLogEvent.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Layouts`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [JsonLayout.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/CrossCuttingConcerns/Logging/Log4Net/Layouts/JsonLayout.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Loggers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [FileLogger.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/CrossCuttingConcerns/Logging/Log4Net/Loggers/FileLogger.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Validation`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📃 [ValidationTool.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/CrossCuttingConcerns/Validation/ValidationTool.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DataAccess`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEntityRepository.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/DataAccess/IEntityRepository.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``EntityFramework`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [EfEntityRepositoryBase.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DependencyResolvers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CoreModule.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/DependencyResolvers/CoreModule.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Entities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Entities/IDto.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IEntity.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Entities/IEntity.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Concrete`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [OperationClaim.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Entities/Concrete/OperationClaim.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [User.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Entities/Concrete/User.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UserOperationClaim.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Entities/Concrete/UserOperationClaim.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Extensions`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ClaimExtensions.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Extensions/ClaimExtensions.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ClaimsPrincipalExtensions.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Extensions/ClaimsPrincipalExtensions.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ServiceCollectionExtensions.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Extensions/ServiceCollectionExtensions.cs) <br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Utilities`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Business`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BusinessRules.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Business/BusinessRules.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Helpers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [FileHelper.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Helpers/FileHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Interceptors`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AspectInterceptorSelector.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Interceptors/AspectInterceptorSelector.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [MethodInterception.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Interceptors/MethodInterception.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [MethodInterceptionBaseAttribute.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``IoC`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ICoreModule.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/IoC/ICoreModule.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ServiceTool.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/IoC/ServiceTool.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Messages`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AspectMessages.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Messages/AspectMessages.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Results`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IDataResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/IDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [DataResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/DataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SuccessDataResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/SuccessDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ErrorDataResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/ErrorDataResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [IResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/IResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Result.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/Result.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SuccessResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/SuccessResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ErrorResult.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Results/ErrorResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Security`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Encryption`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SecurityKeyHelper.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Security/Encryption/ErrorResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [SigningCredentialsHelper.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Security/Encryption/ErrorResult.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Hashing`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [HashingHelper.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Security/Hashing/HashingHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 ``JWT`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AccessToken.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Security/JWT/AccessToken.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ITokenHelper.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Security/JWT/ITokenHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [JwtHelper.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Security/JWT/JwtHelper.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [TokenOptions.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Core/Utilities/Security/JWT/TokenOptions.cs) <br><br>

🗃 **``Presentation Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp; 📃 [Program.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/ConsoleUI/Program.cs)<br><br>

🗃 **``WebAPI Layer``** <br>
&nbsp;&nbsp;&nbsp;&nbsp;📃 [Startup.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/WebAPI/Startup.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Controllers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [AuthController.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/WebAPI/Controllers/AuthController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [BrandsController.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/WebAPI/Controllers/BrandsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarImagesController.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/WebAPI/Controllers/CarImagesController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CarsController.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/WebAPI/Controllers/CarsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [ColorsController.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/WebAPI/Controllers/ColorsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [CustomersController.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/WebAPI/Controllers/CustomersController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentalsController.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/WebAPI/Controllers/RentalsController.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📃 [UsersController.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/WebAPI/Controllers/UsersController.cs) <br><br>

## SQL Query
&nbsp;&nbsp;&nbsp;&nbsp; 📃 [RentACarSQLQuery.sql](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/RentACarSQLQuery.sql)


## Tables in Database
<table>
  <tr>
     <td>Brands</td>
     <td>CarImages</td>
     <td>Cars</td>
     <td>Colors</td>
     <td>Customers</td>
     <td>OperationClaims</td>
     <td>Rentals</td>
     <td>UserOperationClaims</td>
     <td>Users</td>
  </tr>
  <tr>
    <td>
      
Variable Name | Data Type
------------ | -------------
Id | INT
BrandName | NVARCHAR(25)

   
   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
CarId | INT
CarImagesDate | DATETIME
ImagePath | NVARCHAR(MAX)
   
   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
BrandId | INT
ColorId | INT
ModelYear | NVARCHAR(25)
DailyPrice | DECIMAL
Description | NVARCHAR(25)

   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | INT
ColorName | NVARCHAR(25)

   </td>
    <td>


Variable Name | Data Type
------------ | -------------
Id | INT
UserId | INT
CustomerName | NVARCHAR(25)

   </td>
    <td>


Variable Name | Data Type
------------ | -------------
Id | INT
Name  | VARCHAR(250)

   </td>
   <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
CarId | INT
CustomerId | INT
RentDate | DATETIME
ReturnDate | DATETIME

   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
UserId | INT
OperationId | INT

   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
FirstName | VARCHAR(50)
LastName | VARCHAR(50)
Email | VARCHAR(50)
PasswordHash | VARBINARY (500)
PasswordSalt | VARBINARY (500)
Status | BIT

   </td>
  </tr>
 </table>

## Output
<img src="https://user-images.githubusercontent.com/43720773/107849881-381e3280-6e0f-11eb-848d-14c5fc54a4e9.jpg" alt="Console Output"></img>


## Files

![Screenshot_2](https://user-images.githubusercontent.com/43720773/110237584-dce2ea00-7f4d-11eb-9059-306e377d9426.jpg)<br>
![Screenshot_4](https://user-images.githubusercontent.com/43720773/110237586-deacad80-7f4d-11eb-8132-1461695c392a.jpg)<br>
![Screenshot_5](https://user-images.githubusercontent.com/43720773/110237604-ef5d2380-7f4d-11eb-803c-579806c72530.jpg)<br>
![Screenshot_6](https://user-images.githubusercontent.com/43720773/110237605-f08e5080-7f4d-11eb-821a-27dede64b071.jpg)<br>
![Screenshot_7](https://user-images.githubusercontent.com/43720773/110237608-f2f0aa80-7f4d-11eb-954c-375e26394841.jpg)<br>
![Screenshot_8](https://user-images.githubusercontent.com/43720773/110237609-f3894100-7f4d-11eb-9795-1fbe776f2acf.jpg)<br>
![Screenshot_9](https://user-images.githubusercontent.com/43720773/110237610-f4ba6e00-7f4d-11eb-9ffe-2ab5bda1f860.jpg)



## License
[MIT © Selim Gülce](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/LICENSE.txt)  
