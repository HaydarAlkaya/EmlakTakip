//using Core.Entities.Concrete;
//using Core.Utilities.Results;

//namespace Business.Concrete
//{
//    public class OperationClaimManager : IOperationClaimService
//    {
//        private readonly IOperationClaimDal _operationClaimDal;

//        public OperationClaimManager(IOperationClaimDal operationClaimDal)
//        {
//            _operationClaimDal = operationClaimDal;
//        }

//        public IResult Add(OperationClaim t)
//        {
//            _operationClaimDal.Add(t);
//            return new SuccessResult();
//        }

//        public IResult Delete(OperationClaim t)
//        {
//            _operationClaimDal.Delete(t);
//            return new SuccessResult();
//        }

//        public IDataResult<List<OperationClaim>> GetAll()
//        {
//            return new SuccessDataResult<List<OperationClaim>>(_operationClaimDal.GetAll());
//        }

//        public IDataResult<OperationClaim> GetById(int id)
//        {
//            return new SuccessDataResult<OperationClaim>(_operationClaimDal.Get(o => o.Id == id));
//        }

//        public IDataResult<OperationClaim> GetByOperation(string operation)
//        {
//            return new SuccessDataResult<OperationClaim>(_operationClaimDal.Get(u => u.Name == operation));
//        }

//        public IResult Update(OperationClaim t)
//        {
//            _operationClaimDal.Update(t);
//            return new SuccessResult();
//        }
//    }
//}
