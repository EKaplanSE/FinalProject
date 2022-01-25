using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            //GetAllByCategoryId(1);
            CategoryManager categoryMabager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryMabager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

            Console.ReadLine();
        }

        private static void GetAllByCategoryId(int categoryId)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(categoryId))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
