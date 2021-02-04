using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryColorDal : IColorDal
    public class InMemoryColorDal 
    {
        //List<Color> _colors;

        //public InMemoryColorDal()
        //{
        //    _colors = new List<Color>()
        //    {
        //        new Color(){ Id = 1, ColorName = "Siyah"},
        //        new Color(){ Id = 2, ColorName = "Beyaz"},
        //        new Color(){ Id = 3, ColorName = "Mavi"},
        //    };
        //}

        //public void Add(Color entity)
        //{
        //    _colors.Add(entity);
        //}

        //public void Delete(int id)
        //{
        //    var colorToDelete = _colors.SingleOrDefault(b => b.Id == id);
        //    _colors.Remove(colorToDelete);
        //}

        //public List<Color> GetAll()
        //{
        //    return _colors;
        //}

        //public void Update(Color entity)
        //{
        //    var colorToUpdate = _colors.SingleOrDefault(b => b.Id == entity.Id);
        //    colorToUpdate.ColorName = entity.ColorName;
        //}
    }
}
