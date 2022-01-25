using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint : Generic kısıt verilen T tipindeki parametrenin kısıtlanması
    //where T:class,IEntity : şeklinde yapılır. T: IEntity veya IEntity'i implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Expression kullanılarak filtrelenen kayıtların getirilmesi sağlanır.
        //filter=null demek filtreleme olmayabilir bu durumda tüm kayıtları getirir.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
