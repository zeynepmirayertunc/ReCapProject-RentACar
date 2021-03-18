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
        IResult Add(CarImageDetailDto carImagesDto);
        IResult Update(CarImageDetailDto carImagesDto);
        IResult Delete(CarImageDetailDto carImagesDto);
        IDataResult<List<CarImage>> GetByCarImages(int carId);

    }
}
