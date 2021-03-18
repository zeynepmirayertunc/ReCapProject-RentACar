using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;


namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [SecuredOperation("carImage.add,admin")]
        [ValidationAspect(typeof(CarImageValidator))]
        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Add(CarImageDetailDto carImagesDto)
        {
            var result = BusinessRules.Run(CheckCarImagesCount(carImagesDto.CarId));
            if (result != null) return result;
            CarImage carimage = new CarImage
            {
                CarId = carImagesDto.CarId,
                ImagePath = FileHelper.SaveImageFile(carImagesDto.ImageFile),
                Date = DateTime.Now
            };
            _carImageDal.Add(carimage);
            return new SuccessResult(Messages.CarImagesAdded);
        }

        [SecuredOperation("carimage.delete")]
        public IResult Delete(CarImageDetailDto carImagesDto)
        {
            var result = _carImageDal.Get(ci => ci.Id == carImagesDto.Id);
            if (result == null) return new ErrorResult(Messages.CarImagesNotFound);
            FileHelper.DeleteImageFile(result.ImagePath);
            _carImageDal.Delete(result);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetByCarImages(int carId)
        {
            //var result = _carImageDal.Get(ci => ci.CarId == carId);
            //if (result.ImagePath==null)
                
            //{
            //    List<CarImage> carimage = new List<CarImage>();
            //    carimage.Add(new CarImage{ CarId = carId, ImagePath = "default.jpg", Date = DateTime.Now });
            //    return new SuccessDataResult<List<CarImage>>(carimage);


            //}
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(ci => ci.CarId == carId));
        }

        [SecuredOperation("carimage.update")]
        [ValidationAspect(typeof(CarImageValidator))]
        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Update(CarImageDetailDto carImagesDto)
        {
            var result = _carImageDal.Get(ci => ci.Id == carImagesDto.Id);
            if (result == null) return new ErrorResult(Messages.CarImagesNotFound);
            FileHelper.DeleteImageFile(result.ImagePath);
            result.ImagePath = FileHelper.SaveImageFile(carImagesDto.ImageFile);
            result.Date = DateTime.Now;
            _carImageDal.Update(result);
            return new SuccessResult(Messages.CarImagesUpdated);
        }

        private IResult CheckCarImagesCount(int carId)
        {
            var result = _carImageDal.GetAll(ci => ci.CarId == carId).Count < 5;
            if (!result) return new ErrorResult(Messages.CarImageCountError);
            return new SuccessResult();
        }
    }

}

