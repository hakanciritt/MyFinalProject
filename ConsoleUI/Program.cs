using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine($"{product.ProductId} {product.ProductName} {product.CategoryId} " +
                    $" {product.UnitPrice} {product.UnitsInStock}");
            }

            Console.Read();
        }
    }
}
