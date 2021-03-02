using System.Collections.Generic;
using Core.Business;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService : IBaseService<User>
    {
        List<OperationClaim> GetClaims(User user);
        User GetByEmail(string email);
    }
}