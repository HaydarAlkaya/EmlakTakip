﻿using Core.EntityFreamwork;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, EmlakTakipContext>, ICategoryDal
    {
    }
}
