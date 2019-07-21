using CoreTest.BLL.Abstract;
using CoreTest.DAL.Abstract;
using CoreTest.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTest.BLL.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
