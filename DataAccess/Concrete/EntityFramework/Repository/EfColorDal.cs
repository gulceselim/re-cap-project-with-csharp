using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var addedColor = context.Entry(entity);
                addedColor.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var deletedColor = context.Entry(entity);
                deletedColor.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updatedColor = context.Entry(entity);
                updatedColor.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
