using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using Entities.DTOs;
using System.Linq.Expressions;
using System;
using Core.Business;

namespace Business.Abstract
{
    public interface IRentalService : IService<Rental>
    {
        IDataResult<List<RentalDetailDto>> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
    }
}