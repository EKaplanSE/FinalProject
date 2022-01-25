using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // IProductDal : I-Interface Product-Entity Dal-Layer
    // Interface dafault public değildir, metodları publictir.
    public interface IProductDal:IEntityRepository<Product>
    {
        //Product başka bir projede tanımlı olduğu için
        //Öncelikle projeye sağ tıklanıp Add-Project Reference ile 
        //Entities projesi seçilerek referans eklenir.
        //Sonrasında kodda using ile Product'ın namespace'i eklenir. using Entities.Concrete
        /*
        //IEntity Repository kullanınca aşağıdaki koda gerek kalmadı.
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        
        List<Product> GetAllByCategory(int categoryId);
        */

    }
}

//Code Refactoring : Kodun iyileştirilmesi
