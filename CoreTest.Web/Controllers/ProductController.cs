﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTest.BLL.Abstract;
using CoreTest.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreTest.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            ProductListVM model = new ProductListVM()
            {
                Products = products
            };
            return View(model);
        }
    }
}