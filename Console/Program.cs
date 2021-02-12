using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            DBTest();
            //GetCarsByBrandIdTest();
            //AddConditionsTest();
        }

        private static void AddConditionsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car() { Id = 2, Name = "BM", BrandId = 4, ColorId = 2, DailyPrice = 250000, ModelYear = 2020, Descriptions = "Automatic Hybrid Car " };
            carManager.Add(car);
        }

        private static void GetCarsByBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(4).Data)
            {
                Console.WriteLine("Car Id: {0} -- Car Name: {1} -- Color Id: {2}", car.Id, car.Name, car.ColorId);
            }
        }

        private static void DBTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success ==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{1} brand {2} color {0} -- price: {3}", car.CarName, car.BrandName, car.ColorName,
                        car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
