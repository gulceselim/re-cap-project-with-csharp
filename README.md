# ReCap Project : Araba Kiralama Sistemi

- Entities, DataAccess, Business ve Console katmanlarından oluşan araba kiralama console projesidir. Şimdilik Car, Brand ve Color nesnelerinden ve onun operasyonlarından oluşan bu küçük proje zamanla geliştirilecektir. 
- Bir önceki projemde N-Katmanlı Mimari yapısını kullanmıştım ve [README.md](https://github.com/gulceselim/ReCapDemo/blob/master/README.md) dosyasında elimden geldiğince açıklamaya çalışmıştım isterseniz bakabilirsiniz.


### Entities Layer
#### Concrete Classes
1. [Car.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Car.cs)
2. [Brand.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Brand.cs)
3. [Color.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Entities/Concrete/Color.cs)

#### Abstract Classes
1. [IEntity.cs](https://github.com/gulceselim/re-cap-project-with-csharp/tree/main/Entities/Abstract)
    
### Business Layer
#### Concrete Classes
1. [CarManager.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Concrete/CarManager.cs)
  
#### Abstract Classes
1. [ICarService.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/Business/Abstract/ICarService.cs)

### DataAccess Layer
- Memory üzerinde çalıştığım için ayrı bir klasör oluşturdum. Eğer ilerde Entity Framework ile çalışmaya başlarsam (ki bu projede kullanacağız), ona ait olan dosyaları EntityFramework klasörü içinde tutacağım.
#### Concrete Classes
1. [InMemory/InMemoryCarDal.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Concrete/InMemory/InMemoryCarDal.cs)

#### Abstract Classes
1. [ILoggerService](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/DataAccess/Abstract/ICarDal.cs)
  
### UI Layer (Console)
  - Bu katman kullanıcı ile etkileşimin yapıldığı katmandır. Ben Console uygulaması yaptığım için adına Console koydum fakat bu Windows Form uygulamasıda olabilir veya bir Web projesi olabilirdi.
1. [Program.cs](https://github.com/gulceselim/re-cap-project-with-csharp/blob/main/ConsoleUI/Program.cs)

### Output
![Output](https://user-images.githubusercontent.com/43720773/106459695-4bdaa800-64a3-11eb-82fe-8c5eee83aec5.jpg)
