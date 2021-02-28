using Core.Business;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService //: IBaseService<CarImage>
    {
        IResult Add(CarImageDto carImageDto);
        IResult Delete(int carImageId);
        IResult Update(CarImageDto carImageDto);
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetImagesByCarId(int id);
    }
}
