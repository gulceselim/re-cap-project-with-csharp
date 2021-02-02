using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDtoDal : ICarDtoDal
    {
        List<CarDto> _carDtos;
        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _colors;

        public InMemoryCarDtoDal(List<Car> cars, List<Brand> brands, List<Color> colors)
        {
            _cars = cars;
            _brands = brands;
            _colors = colors;
        }

        public List<CarDto> GetAll()
        {
            _carDtos = (from c in _cars
                           join b in _brands on c.BrandId equals b.Id
                           join co in _colors on c.ColorId equals co.Id
                           select new CarDto
                           {
                               Id = c.Id,
                               ColorName = co.ColorName,
                               BrandName = b.BrandName,
                               DailyPrice = c.DailyPrice,
                               Decription = c.Decription,
                               ModelYear = c.ModelYear
                           }).ToList();

            return _carDtos; 
        }
    }
}
