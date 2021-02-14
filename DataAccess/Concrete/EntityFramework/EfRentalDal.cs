using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join car in context.Cars
                                 on r.CarId equals car.Id
                             join c in context.Customers
                                 on r.CustomerId equals c.UserId
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new RentalDetailDto()
                             {
                                 UserName = u.FirstName + " " + u.LastName,
                                 CustomerName = c.CompanyName,
                                 CarName = car.Description
                             };
                return result.ToList();
            }
        }
    }
}