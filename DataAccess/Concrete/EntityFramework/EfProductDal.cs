﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductsDetails()
        {
            using (NorthwindContext Context = new NorthwindContext())
            {
                var result = from p in Context.Products
                             join c in Context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             { ProductId = p.ProductId,ProductName= p.ProductName,
                                  CategoryName= c.CategoryName,UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
