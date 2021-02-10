using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Repository;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            bool cikis = true;

            while (cikis)
            {
                Console.WriteLine(
                    "Rent A Car \n---------------------------------------------------------------" +
                    "\n\n1.Araba Ekleme\n" +
                    "2.Araba Silme\n" +
                    "3.Araba Güncelleme\n" +
                    "4.Arabaların Listelenmesi\n" +
                    "5.Arabaların detaylı bir şekilde Listelenmesi\n" +
                    "6.Arabaların Marka Id'sine göre Listelenmesi\n" +
                    "7.Arabaların Renk Id'sine göre Listelenmesi\n" +
                    "8.Araba Id'sine göre Listeleme\n" +
                    "9.Arabaların fiyat aralığına göre Listelenmesi\n" +
                    "10.Arabaların model yılına göre Listelenmesi\n" +
                    "11.Çıkış\n" +
                    "Yukarıdakilerden hangi işlemi gerçekleştirmek istiyorsunuz ?"
                    );

                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n---------------------------------------------------------------\n");
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Color Listesi");
                        GetAllColor(colorManager);

                        Console.WriteLine("Brand Listesi");
                        GetAllBrand(brandManager);

                        Console.WriteLine("\nBrand Id: ");
                        int brandIdForAdd = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Color Id: ");
                        int colorIdForAdd = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Daily Price: ");
                        decimal dailyPriceForAdd = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Description : ");
                        string descriptionForAdd = Console.ReadLine();

                        Console.WriteLine("Model Year: ");
                        string modelYearForAdd = Console.ReadLine();

                        Car carForAdd = new Car { BrandId = brandIdForAdd, ColorId = colorIdForAdd, DailyPrice = dailyPriceForAdd, Descriptions = descriptionForAdd, ModelYear = modelYearForAdd };
                        carManager.Add(carForAdd);
                        break;

                    case 2:
                        GetAllCarDetails(carManager);
                        Console.WriteLine("Hangi Id'ye sahip arabayı silmek istiyorsunuz? ");
                        int carIdForDelete = Convert.ToInt32(Console.ReadLine());
                        carManager.Delete(carManager.GetById(carIdForDelete));
                        break;


                    case 3:
                        GetAllCarDetails(carManager);
                        Console.WriteLine("Car Id: ");
                        int carIdForUpdate = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Brand Id: ");
                        int brandIdForUpdate = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Color Id: ");
                        int colorIdForUpdate = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Daily Price: ");
                        decimal dailyPriceForUpdate = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Description : ");
                        string descriptionForUpdate = Console.ReadLine();

                        Console.WriteLine("Model Year: ");
                        string modelYearForUpdate = Console.ReadLine();

                        Car carForUpdate = new Car {CarId = carIdForUpdate, BrandId = brandIdForUpdate, ColorId = colorIdForUpdate, DailyPrice = dailyPriceForUpdate, Descriptions = descriptionForUpdate, ModelYear = modelYearForUpdate };
                        carManager.Update(carForUpdate);
                        break;

                    case 4:
                        Console.WriteLine("Arabaların Listesi:  \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
                        GetAllCar(carManager);
                        break;

                    case 5:
                        Console.WriteLine("Arabaların detaylı listesi:  \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
                        GetAllCarDetails(carManager);
                        break;

                    case 6:
                        GetAllBrand(brandManager);
                        Console.WriteLine("Hangi markaya sahip arabayı görmek istiyorsunuz? Lütfen bir Id numarası yazınız.");
                        int brandIdForCarList = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\n\nBrand Id'si {brandIdForCarList} olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
                        foreach (var car in carManager.GetAllByBrandId(brandIdForCarList))
                        {
                            Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
                        }
                        break;

                    case 7:
                        GetAllColor(colorManager);
                        Console.WriteLine("Hangi renge sahip arabayı görmek istiyorsunuz? Lütfen bir Id numarası yazınız.");
                        int colorIdForCarList = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\n\nColor Id'si {colorIdForCarList} olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
                        foreach (var car in carManager.GetAllByColorId(colorIdForCarList))
                        {
                            Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
                        }
                        break;

                    case 8:
                        GetAllCarDetails(carManager);
                        Console.WriteLine("Hangi arabayı görmek istiyorsunuz? Lütfen bir Id numarası yazınız.");
                        int carId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\n\nId'si {carId} olan araba: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
                        Car carById = carManager.GetById(carId);
                        Console.WriteLine($"{carById.CarId}\t{colorManager.GetById(carById.ColorId).ColorName}\t\t{brandManager.GetById(carById.BrandId).BrandName}\t\t{carById.ModelYear}\t\t{carById.DailyPrice}\t\t{carById.Descriptions}");
                        break;

                    case 9:
                        decimal min = Convert.ToDecimal(Console.ReadLine());
                        decimal max = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine($"\n\nGünlük fiyat aralığı {min} ile {max} olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
                        foreach (var car in carManager.GetByDailyPrice(min, max))
                        {
                            Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
                        }
                        break;

                    case 10:
                        GetAllCarDetails(carManager);
                        Console.WriteLine("Hangi model yılına sahip arabayı görmek istiyorsunuz? Lütfen yıl değeri giriniz.");
                        string modelYearForCarList = Console.ReadLine();
                        Console.WriteLine($"\n\nColor Id'si {modelYearForCarList} olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
                        foreach (var car in carManager.GetByModelYear(modelYearForCarList))
                        {
                            Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
                        }
                        break;
                    case 11:
                        cikis = false;
                        Console.WriteLine("Çıkış işlemi gerçekleşti.");
                        break;
                }
            }
        }

        private static void GetAllCarDetails(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"{car.CarId}\t{car.ColorName}\t\t{car.BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }
        }

        private static void GetAllCar(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.CarId}\t{car.ColorId}\t\t{car.BrandId}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }
        }

        private static void GetAllBrand(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine($"{brand.BrandId}\t{brand.BrandName}");
            }
        }

        private static void GetAllColor(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine($"{color.ColorId}\t{color.ColorName}");
            }
        }
    }
}
