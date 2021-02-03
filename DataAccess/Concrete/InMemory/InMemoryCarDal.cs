using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, Description="Automatic Gear Gasoline Car ", DailyPrice=10000, ModelYear="2019"},
                new Car{CarId=2, BrandId=1, ColorId=2, Description="Manuel Gear Diesel Car ", DailyPrice=20000, ModelYear="2015"},
                new Car{CarId=3, BrandId=2, ColorId=3, Description="Automatic Gear Hybrid Car ", DailyPrice=30500, ModelYear="2018"},
                new Car{CarId=4, BrandId=2, ColorId=3, Description="Automatic Gear Electric Car  ", DailyPrice=400000, ModelYear="2020"},
                new Car{CarId=5, BrandId=3, ColorId=4, Description="Manuel Gear Gas Car ", DailyPrice=5000, ModelYear="2008"},
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carsToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carsToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carsToUpdate.Description = car.Description;
            carsToUpdate.ColorId = car.ColorId;
            carsToUpdate.DailyPrice = car.DailyPrice;
            carsToUpdate.ModelYear = car.ModelYear;
           

        }
    }
}
