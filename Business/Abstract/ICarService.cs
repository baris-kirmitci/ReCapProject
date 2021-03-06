using Entity.Conctere;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByDailyPrice(decimal min, decimal max);
        void Add(Car car);
    }
}
