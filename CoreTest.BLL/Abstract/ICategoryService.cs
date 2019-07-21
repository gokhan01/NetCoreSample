using CoreTest.Entities.Concrete;
using System.Collections.Generic;

namespace CoreTest.BLL.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
