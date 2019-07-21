using CoreTest.Core.DAL.EntityFramework;
using CoreTest.DAL.Abstract;
using CoreTest.Entities.Concrete;

namespace CoreTest.DAL.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
