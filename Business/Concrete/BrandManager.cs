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
        IBrandDal _brandDal;

        public BrandManager(IBrandDal iBrandDal)
        {
            _brandDal = iBrandDal;
        }
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
                _brandDal.Add(brand);
            else
                throw new Exception("The name of car must be at least 2 characters");
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(b => b.BrandId == id);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
                _brandDal.Update(brand);
            else
                Console.WriteLine("The name of car must be at least 2 characters");
        }
    }
}
