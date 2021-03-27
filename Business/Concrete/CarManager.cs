using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Conctere.EntityFramework;
using Entity.Conctere;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

       public void Add(Car car)
        {
            if (car.Description.Length >=2 && car.DailyPrice >0 )
            {
                Console.WriteLine("ARAÇ BAŞARIYLA EKLENMİŞTİR");
                Console.WriteLine(" " + car.CarId + "            " + car.Description + "               " + car.ColorId + "            " + car.BrandId + "            " + car.DailyPrice);
            }
            else {
                Console.WriteLine();
                Console.WriteLine("!!!!! HATA : ARAÇ ADI EN AZ 2 KARAKTER VE GÜNLÜK FİYATI 0'IN ÜZERİNDE OLMALIDIR !!!!!");

            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

       

        public List<Car> GetAllByBrandId(int id)
        { return _carDal.GetAll(c => c.BrandId == id);
        }
    
        public  List<Car> GetAllByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c=> c.DailyPrice >=min && c.DailyPrice <=max);
        }
    
    }
}
