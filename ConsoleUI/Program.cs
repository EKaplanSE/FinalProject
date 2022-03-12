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
            //CategoryTest();
            ProductTest();
            Console.ReadLine();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryMabager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryMabager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void GetAllByCategoryId(int categoryId)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(categoryId).Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

    
    }
    
}
