using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal brandDal)
        {
            _colorDal = brandDal;
        }

        public void Add(Color entity)
        {
            _colorDal.Add(entity);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();

        }

        public Color GetById(int id)
        {
            return _colorDal.Get(c => c.ColorId == id);
        }

        public void Update(Color entity)
        {
            _colorDal.Update(entity);
        }
    }
}
