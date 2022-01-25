using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//EntityFramework bir ORM'dir. (Object Relational Mapping)
//ORM : Veritabanı nesneleriyle kodlar arasında bağ kurup veritabanı işlerini yapma süreci
//EntityFramwork .Net üzerinde gelen Microsoft'a ait bir pakettir.

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {     

    }
}
