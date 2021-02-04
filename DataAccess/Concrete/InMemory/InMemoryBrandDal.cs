using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryBrandDal : IBrandDal
    public class InMemoryBrandDal
    {
        //List<Brand> _brands;

        //public InMemoryBrandDal()
        //{
        //    _brands = new List<Brand>()
        //    {
        //        new Brand(){ Id = 1, BrandName = "Mercedes"},
        //        new Brand(){ Id = 2, BrandName = "BMW"},
        //        new Brand(){ Id = 3, BrandName = "Volvo"},
        //    };
        //}

        //public void Add(Brand entity)
        //{
        //    _brands.Add(entity);
        //}

        //public void Delete(int id)
        //{
        //    var brandToDelete = _brands.SingleOrDefault(b => b.Id == id);
        //    _brands.Remove(brandToDelete);
        //}

        //public List<Brand> GetAll()
        //{
        //    return _brands;
        //}

        //public void Update(Brand entity)
        //{
        //    var brandToUpdate = _brands.SingleOrDefault(b => b.Id == entity.Id);
        //    brandToUpdate.BrandName = entity.BrandName;
        //}
    }
}
