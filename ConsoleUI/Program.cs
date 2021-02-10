using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " " + product.CategoryName);
                }
            }
            

            //CategoryManager manager = new CategoryManager(new EfCategoryDal());

            //foreach (var category in manager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}



            Console.Read();
        }
    }
}
