using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        private readonly IUserOperationClaimDal _userOperationClaimDal;

        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal)
        {
            _userOperationClaimDal = userOperationClaimDal;
        }

        public IResult Add(UserOperationClaim t)
        {
            _userOperationClaimDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(UserOperationClaim t)
        {
            _userOperationClaimDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<UserOperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaimDal.GetAll());
        }

        public IDataResult<UserOperationClaim> GetById(int id)
        {
            return new SuccessDataResult<UserOperationClaim>(_userOperationClaimDal.Get(u=>u.Id == id));
        }
        public IDataResult<UserOperationClaim> GetByUserId(int id)
        {
            return new SuccessDataResult<UserOperationClaim>(_userOperationClaimDal.Get(u => u.UserId == id));
        }

        public IResult Update(UserOperationClaim t)
        {
            _userOperationClaimDal.Update(t);
            return new SuccessResult();
        }
    }
}
