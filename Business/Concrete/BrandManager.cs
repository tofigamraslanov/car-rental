using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _iBrandDal;

        public BrandManager(IBrandDal iBrandDal)
        {
            _iBrandDal = iBrandDal;
        }
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
                _iBrandDal.Add(brand);
            else
                Console.WriteLine("The name of car must be at least 2 characters");
        }

        public void Delete(Brand brand)
        {
            _iBrandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _iBrandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _iBrandDal.Get(b => b.BrandId == id);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
                _iBrandDal.Update(brand);
            else
                Console.WriteLine("The name of car must be at least 2 characters");
        }
    }
}
