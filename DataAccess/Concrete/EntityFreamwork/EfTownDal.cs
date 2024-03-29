using Core.EntityFreamwork;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfTownDal : EfEntityRepositoryBase<Town, EmlakTakipContext>, ITownDal
    {
    }
}
