using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IResult Add(IFormFile formFile,CarImage carImage);
        IDataResult<CarImage> GetByCarId(int carId);
        IResult Update(CarImage carImage);
        IResult Delete(CarImage carImage);
        IDataResult<List<CarImageDetailDto>> GetCarImagesDetail();
        IDataResult<List<CarImage>> GetCarImages(int carId);
    }
}
