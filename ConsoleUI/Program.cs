using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("Bütün Arabalar \nId\tColor Id\tBrand Id\tModel Year\tDaily Price\tDescription");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.Id}\t{car.ColorId}\t\t{car.BrandId}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Decription}");
            }

            Console.WriteLine("\n\nBrand Id'si 1 olan arabalar: \nId\tColor Id\tBrand Id\tModel Year\tDaily Price\tDescription");
            foreach (var car in carManager.GetAllByBrand(1))
            {
                Console.WriteLine($"{car.Id}\t{car.ColorId}\t\t{car.BrandId}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Decription}");
            }

            Console.WriteLine("\n\nColor Id'si 2 olan arabalar: \nId\tColor Id\tBrand Id\tModel Year\tDaily Price\tDescription");
            foreach (var car in carManager.GetAllByColor(2))
            {
                Console.WriteLine($"{car.Id}\t{car.ColorId}\t\t{car.BrandId}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Decription}");
            }

            Console.WriteLine("\n\nId'si 3 olan araba: \nId\tColor Id\tBrand Id\tModel Year\tDaily Price\tDescription");
            Car carById = carManager.GetById(3);  
            Console.WriteLine($"{carById.Id}\t{carById.ColorId}\t\t{carById.BrandId}\t\t{carById.ModelYear}\t\t{carById.DailyPrice}\t\t{carById.Decription}");



            Console.WriteLine("\n\nDeğişiklikten Önce: \nId\tColor Id\tBrand Id\tModel Year\tDaily Price\tDescription");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.Id}\t{car.ColorId}\t\t{car.BrandId}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Decription}");
            }

            carManager.Add(new Car { Id = 5, BrandId = 1, ColorId = 2, DailyPrice = 300, ModelYear = 2021, Decription = "Otomatik Dizel" });
            carManager.Delete(3);
            Car carForUpdate = new Car() { Id = 1, BrandId = 3, ColorId = 3, DailyPrice = 350, ModelYear = 2012, Decription = "Otomatik Hybrid"};
            carManager.Update(carForUpdate);


            Console.WriteLine("\n\nDeğişiklikten Sonra: \nId\tColor Id\tBrand Id\tModel Year\tDaily Price\tDescription");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.Id}\t{car.ColorId}\t\t{car.BrandId}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Decription}");
            }

        }
    }
}
