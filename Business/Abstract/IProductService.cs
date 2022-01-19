using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //Business prjesine sğ tıklanıp Add > Reference Project ile
    // DataAccess ve Entities projeleri referans gösterilir.
    public interface IProductService
    {
        List<Product> GetAll();

    }
}
