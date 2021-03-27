using DataAccess.Abstract;
using Entity.Conctere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Conctere
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {

            new Car{CarId=1,CategoryId=1,BrandId=1,ColorId=7,Description="A5",ModelYear=2011,DailyPrice=25000},
            new Car{CarId=2,CategoryId=1,BrandId=1,ColorId=256,Description="A9",ModelYear=2012,DailyPrice=33090},
            new Car{CarId=3,CategoryId=2,BrandId=2,ColorId=34,Description="M5",ModelYear=2013,DailyPrice=4000},
            new Car{CarId=4,CategoryId=1,BrandId=3,ColorId=1,Description="Scirocco",ModelYear=2015,DailyPrice=23000},
            new Car{CarId=5,CategoryId=3,BrandId=4,ColorId=94,Description="Polo",ModelYear=2017,DailyPrice=17500},
           
            
            };
        }
        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetAllCategoryId(int CategoryId)
        {
            return _cars.Where(c => c.CategoryId == c.CategoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpDate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carUpDate.CarId = car.CarId;
            carUpDate.CategoryId = car.CategoryId;
            carUpDate.BrandId = car.BrandId;
            carUpDate.Description = car.Description;
            carUpDate.ModelYear = car.ModelYear;
            carUpDate.DailyPrice = car.DailyPrice;
            carUpDate.ColorId = car.ColorId;


        }

        public void UpDate(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
