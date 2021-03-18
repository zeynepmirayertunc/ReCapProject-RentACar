using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{Id=1, BrandId=1, ColorId=2, Descriptions="Yarı otomatik dizel araç ", DailyPrice=40000, ModelYear=2017},
                new Car{Id=2, BrandId=3, ColorId=1, Descriptions="Otomatik benzinli araç ", DailyPrice=100000, ModelYear=2016},
                new Car{Id=3, BrandId=4, ColorId=3, Descriptions="Yarı otomatik dizel araç ", DailyPrice=56000, ModelYear=2015},
                new Car{Id=4, BrandId=2, ColorId=4, Descriptions="Otomatik hibrit araç  ", DailyPrice=1000000, ModelYear=2020},
                new Car{Id=5, BrandId=4, ColorId=2, Descriptions="Manuel lpgli araç ", DailyPrice=5000, ModelYear=2003},
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carsToDelete);
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
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }


        public void Update(Car car)
        {
            Car carsToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carsToUpdate.Descriptions = car.Descriptions;
            carsToUpdate.ColorId = car.ColorId;
            carsToUpdate.DailyPrice = car.DailyPrice;
            carsToUpdate.ModelYear = car.ModelYear;
           

        }
    }
}
