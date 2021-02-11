using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using Business.Constants;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].ReturnDate == null || result[i].RentDate < result[i].ReturnDate)
                {
                    return new ErrorResult(Messages.RentalValidate);
                }
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);

            //var result = _rentalDal.Get(r => r.CarId == rental.CarId);
            //if (result != null && rental.ReturnDate == null)
            //{
            //    return new ErrorResult(Messages.RentalValidate);
            //}
            //_rentalDal.Add(rental);
            //rental.ReturnDate = null;
            //return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}