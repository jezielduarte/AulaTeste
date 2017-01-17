using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Repositorios
{
    public class RepositorioBase
    {
        public class RepositoryBase<TEntity> where TEntity : class
        {
            protected Contexto Db = new Contexto();

            public void Add(TEntity obj)
            {
                Db.Set<TEntity>().Add(obj);
                Db.SaveChanges();
            }

            public TEntity GetById(int id)
            {
                return Db.Set<TEntity>().Find(id);
            }

            public IEnumerable<TEntity> GetAll()
            {
                return Db.Set<TEntity>().ToList();
            }

            public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
            {
                return Db.Set<TEntity>().Where(predicate).ToList();
            }

            public void Update(TEntity obj)
            {
                Db.Entry(obj).State = EntityState.Modified;
                Db.SaveChanges();
            }

            public void Remove(TEntity obj)
            {
                Db.Set<TEntity>().Remove(obj);
                Db.SaveChanges();
            }
        }
    }
}
