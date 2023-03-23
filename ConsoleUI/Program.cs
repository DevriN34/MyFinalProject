using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Program
{
    static void Main(string[] args)
    {
        ProductName();
        // CategoryName();
    }

    private static void CategoryName()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductName()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var Product in productManager.GetProductDetailDtos())
        {
            Console.WriteLine(Product.ProductName + "/" +Product.CategoryName);
        }
    }
}