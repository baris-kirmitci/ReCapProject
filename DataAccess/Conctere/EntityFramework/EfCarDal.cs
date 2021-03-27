using DataAccess.Abstract;
using Entity.Conctere;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Conctere.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
     { 
        using(CarDbContext context = new CarDbContext())
	{
        var addedEntity = context.Entry(entity);
         addedEntity.State = EntityState.Added;
         context.SaveChanges();
	}
     
     }

        public void Delete(Car entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return filter == null

                    ? context.Set<Car>().ToList()
              
                    : context.Set<Car>().Where(filter).ToList();

            }
        }

        public void UpDate(Car entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
