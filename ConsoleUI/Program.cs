using Business.Concrete;
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
        ProductManager productManager = new ProductManager(new InMemoryProductDal());

        foreach (var Product in productManager.GetAll())
        {
            Console.WriteLine(Product.ProductName);
        }
    }
}