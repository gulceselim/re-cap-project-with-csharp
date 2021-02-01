using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {   
        Car GetById(int id);
        List<Car> GetAll();
        List<Car> GetAllByColor(int colorId);
        List<Car> GetAllByBrand(int brandId);
        void Add(Car car);
        void Update(Car car);
        void Delete(int id);

    }
}
