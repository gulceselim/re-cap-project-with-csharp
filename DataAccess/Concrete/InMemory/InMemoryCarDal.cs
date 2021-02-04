using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryCarDal : ICarDal
    public class InMemoryCarDal
    {
        //List<Car> _cars;

        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>()
        //    {
        //        new Car{Id= 1, BrandId = 1, ColorId = 1, DailyPrice = 200, ModelYear = "2012", Descriptions = "Otomatik Dizel" },    
        //        new Car{Id= 2, BrandId = 2, ColorId = 2, DailyPrice = 50, ModelYear = "2010", Descriptions = "Manuel Benzin" },
        //        new Car{Id= 3, BrandId = 2, ColorId = 1, DailyPrice = 100, ModelYear = "2019", Descriptions = "Manuel Dizel" },
        //        new Car{Id= 4, BrandId = 3, ColorId = 2, DailyPrice = 150, ModelYear = "2018", Descriptions = "Otomatik Benzin" },
        //    };
        //}

        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(int id)
        //{
        //    Car carToDelete = _cars.SingleOrDefault(c => c.Id == id);
        //    _cars.Remove(carToDelete);
        //}

        //public List<Car> GetAll()
        //{
        //    return _cars;   
        //}

        //public List<Car> GetAllByBrand(int brandId)
        //{
        //    return _cars.Where(c => c.BrandId == brandId).ToList();
        //}

        //public List<Car> GetAllByColor(int colorId)
        //{
        //    return _cars.Where(c => c.ColorId == colorId).ToList();
        //}

        //public Car GetById(int id)
        //{
        //    return _cars.SingleOrDefault(c => c.Id == id);
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.ModelYear = car.ModelYear;
        //    carToUpdate.Descriptions = car.Descriptions;
        //}
    }
}
