using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Helpers;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDal _carImageDal;
        private readonly ICarService _carService;

        public CarImageManager(ICarImageDal carImageDal, ICarService carService)
        {
            _carImageDal = carImageDal;
            _carService = carService;
        }

        #region MyRegion


        //[ValidationAspect(typeof(CarImageDtoValidator))]
        //public IResult Add(IFormFile file, CarImageDto carImageDto)
        //{
        //    IResult result = BusinessRules.Run(CheckCarImageCount(carImageDto.CarId));

        //    if (result != null)
        //        return result;

        //    CarImage carImage = new CarImage
        //    {
        //        CarId = carImageDto.CarId,
        //        ImagePath = FileHelper.Add(file),
        //        Date = DateTime.Now
        //    };

        //    //carImage.ImagePath = FileHelper.Add(file);
        //    //carImage.Date = DateTime.Now;

        //    _carImageDal.Add(carImage);
        //    return new SuccessResult(Messages.CarImageAdded);
        //}

        //public IResult Delete(int carImageId)
        //{
        //    var entity = _carImageDal.Get(ci => ci.Id == carImageId);
        //    if (entity == null)
        //        return new ErrorResult(Messages.CarImageNotFound);

        //    FileHelper.Delete(entity.ImagePath);
        //    _carImageDal.Delete(entity);
        //    return new SuccessResult(Messages.CarImageDeleted);
        //}

        //public IResult Update(IFormFile file, CarImageDto carImageDto)
        //{
        //    IResult result = BusinessRules.Run(CheckCarImageCount(carImageDto.CarId));
        //    if (result != null)
        //        return result;

        //    var imagePath = FileHelper.Update(_carImageDal.Get(c => c.Id == carImageDto.Id).ImagePath, file);
        //    CarImage carImage = new CarImage()
        //    {
        //        Id = carImageDto.Id,
        //        ImagePath = imagePath,
        //        Date = DateTime.Now
        //    };

        //    //carImage.ImagePath = FileHelper.Update(_carImageDal.Get(c => c.Id == carImage.Id).ImagePath, file);
        //    //carImage.Date = DateTime.Now;

        //    _carImageDal.Update(carImage);
        //    return new SuccessResult(Messages.CarImageUpdated);
        //}

        #endregion

        [ValidationAspect(typeof(AddCarImageValidator))]
        public IResult Add(CarImageDto carImageDto)
        {
            var result = BusinessRules.Run(CheckCarImageCount(carImageDto.CarId));
            if (result != null) return result;
            CarImage carImage = new CarImage
            {
                CarId = carImageDto.CarId,
                ImagePath = FileHelper.SaveImageFile(carImageDto.ImageFile),
                Date = DateTime.Now
            };
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        [ValidationAspect(typeof(UpdateCarImageValidator))]
        public IResult Update(CarImageDto carImagesDto)
        {
            var entity = _carImageDal.Get(ci => ci.Id == carImagesDto.Id);
            if (entity == null) return new ErrorResult(Messages.CarImageNotFound);
            FileHelper.DeleteImageFile(entity.ImagePath);
            entity.ImagePath = FileHelper.SaveImageFile(carImagesDto.ImageFile);
            entity.Date = DateTime.Now;
            _carImageDal.Update(entity);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        public IResult Delete(int id)
        {
            var entity = _carImageDal.Get(ci => ci.Id == id);
            if (entity == null) return new ErrorResult(Messages.CarImageNotFound);
            FileHelper.DeleteImageFile(entity.ImagePath);
            _carImageDal.Delete(entity);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int carId)
        {
            IResult result = BusinessRules.Run(CheckIfCarIdExists(carId));
            if (result != null)
                return new ErrorDataResult<List<CarImage>>(result.Message);

            var images = _carImageDal.GetAll(ci => ci.CarId == carId);
            if (images.Any())
                return new SuccessDataResult<List<CarImage>>(images);

            return new SuccessDataResult<List<CarImage>>(new List<CarImage>
            {
                new CarImage{ ImagePath = "default.jpg", Date = DateTime.Now }
            });
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id));
        }

        private IResult CheckCarImageCount(int carId)
        {
            if (_carImageDal.GetAll(c => c.CarId == carId).Count > 4)
                return new ErrorResult(Messages.CarImageCountExceeded);

            return new SuccessResult();
        }

        private IResult CheckIfCarIdExists(int carId)
        {
            if (!_carService.GetById(carId).IsSuccess)
                return new ErrorResult(Messages.CarIdDoesNotExist);

            return new SuccessResult();
        }
    }
}
