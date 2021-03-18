using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from ca in context.Cars
                join b in context.Brands
                             on ca.BrandId equals b.Id
                             join cl in context.Colors
                             on ca.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 CarId =ca.Id,
                                 Name=ca.Name,
                                 ModelYear=ca.ModelYear,
                                 BrandName = b.Name,
                                 ColorName = cl.Name,
                                 DailyPrice = ca.DailyPrice,
                                 Description =ca.Descriptions
              
                             };

                return result.ToList();

            }
        }
    }
}
