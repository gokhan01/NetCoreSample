using CoreTest.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTest.BLL.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
