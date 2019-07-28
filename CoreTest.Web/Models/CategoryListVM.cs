using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTest.Entities.Concrete;

namespace CoreTest.Web.Models
{
    public class CategoryListVM
    {
        public List<Category> Categories { get; internal set; }
    }
}
