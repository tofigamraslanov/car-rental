using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;

        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
                _iCarDal.Add(car);
            else
                Console.WriteLine("The daily price of car must be greater than zero");
        }

        public void Delete(Car car)
        {
            _iCarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _iCarDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public Car GetById(int id)
        {
            return _iCarDal.Get(c => c.Id == id);
        }

        public List<Car> GetByModelYear(string year)
        {
            return _iCarDal.GetAll(c => c.ModelYear == year);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _iCarDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _iCarDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0)
                _iCarDal.Update(car);
            else
                Console.WriteLine("The daily price of car must be greater than zero");
        }
    }
}
