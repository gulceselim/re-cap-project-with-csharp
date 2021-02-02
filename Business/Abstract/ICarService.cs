using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        Car GetById(int id);
        List<Car> GetAll();
        List<Car> GetAllByColor(int colorId);
        List<Car> GetAllByBrand(int brandId);
    }
}
