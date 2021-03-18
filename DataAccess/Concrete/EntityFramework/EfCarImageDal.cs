using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, CarContext>, ICarImageDal
    {
        //public List<CarImageDetailDto> GetCarImageDetails()
        //{
        //    using (CarContext context = new CarContext())
        //    {
        //        var result = from ca in context.Cars
        //                     join ci in context.CarImages
        //                     on ca.Id equals ci.CarId
        //                     select new CarImageDetailDto
        //                     {
        //                         CarId = ca.Id,
        //                         CarName = ca.Name,
        //                         ImagePath = ci.ImagePath,

        //                     };
        //        return result.ToList();
        //    }
       
    }

}

