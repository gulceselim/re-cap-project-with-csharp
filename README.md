# ReCap Project : Araba Kiralama Sistemi

- Entities, DataAccess, Business ve Console katmanlarından oluşan araba kiralama console projesidir. Şimdilik Car, Brand ve Color nesnelerinden ve onun operasyonlarından oluşan bu küçük proje zamanla geliştirilecektir. 
- Bir önceki projemde N-Katmanlı Mimari yapısını kullanmıştım ve [README.md](https://github.com/gulceselim/ReCapDemo/blob/master/README.md) dosyasında elimden geldiğince açıklamaya çalışmıştım isterseniz bakabilirsiniz.
- Bu projede farklı olarak, classlarımdaki operasyonların tekrarını önlemek için Generic class'ları kullandım.(DRY)


### Entities Layer
#### Concrete Classes
1. [Car.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Car.cs)
2. [Brand.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Brand.cs)
3. [Color.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Color.cs)

#### Abstract Classes
1. [IEntity.cs](https://github.com/gulceselim/re-cap-project-with-csharp/tree/main/Entities/Abstract)

#### DTO Classes
1. [CarDto.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Dto/CarDto.cs)

### Business Layer
#### Concrete Classes
1. [CarManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/CarManager.cs)
2. [BrandManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/BrandManager.cs)
3. [CarDtoManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/CarDtoManager.cs)
4. [ColorManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/ColorManager.cs)
  
#### Abstract Classes
1. [ICarService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/ICarService.cs)
2. [ICarDtoService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/ICarDtoService.cs)
3. [IBrandService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IBrandService.cs)
4. [IColorService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IColorService.cs)
5. [IGenericService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/IGenericService.cs)

### DataAccess Layer
- Memory üzerinde çalıştığım için ayrı bir klasör oluşturdum. Eğer ilerde Entity Framework ile çalışmaya başlarsam (ki bu projede kullanacağız), ona ait olan dosyaları EntityFramework klasörü içinde tutacağım.
#### Concrete Classes
1. [InMemory/InMemoryCarDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/InMemory/InMemoryCarDal.cs)
2. [InMemory/InMemoryBrandDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/InMemory/InMemoryBrandDal.cs)
3. [InMemory/InMemoryCarDtoDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/InMemory/InMemoryCarDtoDal.cs)
4. [InMemory/InMemoryColorDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/InMemory/InMemoryColorDal.cs)

#### Abstract Classes
1. [ICarDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/ICarDal.cs)
2. [IBrandDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IBrandDal.cs)
3. [ICarDtoDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/ICarDtoDal.cs)
4. [IColorDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IColorDal.cs)
5. [IGenericDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/IGenericDal.cs)
  
### UI Layer (Console)
1. [Program.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/ConsoleUI/Program.cs)

### Tables
#### Car
Variable Name | Data Type
------------ | -------------
Id | int
BrandId | int
ColorId | int
ModelYear | string
DailyPrice | decimal
Description | string

#### CarDto
Variable Name | Data Type
------------ | -------------
Id | int
BrandName | string
ColorName | string 
ModelYear | string
DailyPrice | decimal
Description | string

#### Color
Variable Name | Data Type
------------ | -------------
Id | int
ColorName | string

#### Brand
Variable Name | Data Type
------------ | -------------
Id | int
BrandName | string

### Output
![Console Output](https://user-images.githubusercontent.com/43720773/106571437-353a5c80-6548-11eb-9e98-fb96dd3cbf7d.jpg)

### Files
![Files](https://user-images.githubusercontent.com/43720773/106573499-c7436480-654a-11eb-9bbf-48e2c5b2c98f.jpg)
