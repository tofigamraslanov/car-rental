using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetByModelYear(string year);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
