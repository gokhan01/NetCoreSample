using CoreTest.Core.DAL.EntityFramework;
using CoreTest.DAL.Abstract;
using CoreTest.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTest.DAL.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
