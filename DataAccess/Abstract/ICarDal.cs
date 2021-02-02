using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IGenericDal<Car>
    {   
        Car GetById(int id);
        List<Car> GetAllByColor(int colorId);
        List<Car> GetAllByBrand(int brandId);

    }
}
