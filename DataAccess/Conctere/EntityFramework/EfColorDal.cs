using Entity.Conctere;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Conctere.EntityFramework
{
  public  class EfColorDal
    {
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void UpDate(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
