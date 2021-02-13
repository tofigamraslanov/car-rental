using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                             join car in context.Cars
                                 on r.CarId equals car.Id
                             join c in context.Customers
                                 on r.CustomerId equals c.UserId
                             select new RentalDetailDto()
                             {
                                 CustomerName = c.CompanyName,
                                 CarName = car.Description
                             };
                return result.ToList();
            }
        }
    }
}