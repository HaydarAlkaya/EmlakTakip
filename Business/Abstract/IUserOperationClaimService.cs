using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserOperationClaimService : IBaseService<UserOperationClaim>
    {
        IDataResult<UserOperationClaim> GetByUserId(int id);
    }
}
