using Core.Entities.Concrete;
using Core.EntityFreamwork;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfOperationClaimDal : EfEntityRepositoryBase<OperationClaim , EmlakTakipContext> , IOperationClaimDal
    {
    }
}
