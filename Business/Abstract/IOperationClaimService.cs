using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IOperationClaimService : IBaseService<OperationClaim>
    {
        IDataResult<OperationClaim> GetByOperation(string operation);
    }
}
