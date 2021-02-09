using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            if (car.DailyPrice>0 && car.Name.Length>2)
            {
                _carDal.Add(car);
                Console.WriteLine("New Car Added");
            }

            else
            {
                Console.WriteLine("Invalid transaction!!! Please check your transaction ");
            }
           
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            
        }

        public List<Car> GetAll()
        {
            // business codes
            return _carDal.GetAll();
        }

        public List<Car> GetById(int carId)
        {
            return _carDal.GetAll(c => c.Id == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
        public void Update(Car car)
        {
            if (car.DailyPrice>0 && car.Name.Length>2)
            {
                Console.WriteLine("Cars are updated");
            }
            else
            {
                Console.WriteLine("Invalid transaction please check your transaction.");
            }
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c=>c.BrandId == brandId);
        }

        List<Car> ICarService.GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c=>c.ColorId == colorId);
        }
    }
}
