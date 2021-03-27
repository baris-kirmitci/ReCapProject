using Business.Concrete;
using DataAccess.Conctere;
using DataAccess.Conctere.EntityFramework;
using Entity.Conctere;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
   public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { CarId = 7, BrandId = 2, CategoryId=7,ColorId=6,DailyPrice=100000,Description="C200"};
            Car car2 = new Car { CarId = 5, BrandId = 9, CategoryId=5,ColorId=3,DailyPrice=0,Description="POLO"};
            Car car3 = new Car { CarId = 6, BrandId = 4, CategoryId=2,ColorId=1,DailyPrice=36500,Description="m"};
           CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("CAR IDS"+" --- " + "DESCRIPTIONS" + " --- " + "COLORS" + " --- " + "BRAND IDS" + " --- " + "DAILY PRICES");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(" "+car.CarId + "            " + car.Description + "               " + car.ColorId + "            " + car.BrandId + "            " + car.DailyPrice);




            }
            Console.WriteLine();
            Console.WriteLine("YENİ ARAÇ GİRİŞİ : ");
            Console.WriteLine();
            carManager.Add(car1);
          
            carManager.Add(car2);
           

            
        }
    }
}
