using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions; // Expression Function kullanabilmek için bunu ekledik



namespace cafe_yonetim_sistemi_Enities.Interfaces
{
    public interface IEntityRepository <TContext, TEntity>
      where TContext : DbContext, new()
      where TEntity : class, TEntity, new() // şart Koydum Where ile
    {
        bool AddOrUpdate(TContext context, TEntity entity);
        void Delete(TContext context, Expression<Func<TEntity, bool>> filter);
        void Save(TContext context);

        List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null);  // getAll diye metot oluşturduk filtre başlangıçta boş null geçtik liste için
        TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter); // GetByFilter diye metot oluşturduk tek kayıt için
    }
}
