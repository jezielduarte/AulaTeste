using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Repositorios
{
    public class RepositorioBase<TEntity> where TEntity : class
    {
        protected Contexto contexto;

        public RepositorioBase(Contexto contexto)
        {
            this.contexto = contexto;
        }
        public RepositorioBase()
        {
            this.contexto = new Contexto();
        }
        public TEntity Add(TEntity obj)
        {
            TEntity t = contexto.Set<TEntity>().Add(obj);
            contexto.SaveChanges();
            return t;
        }

        public TEntity GetById(int id)
        {
            return contexto.Set<TEntity>().Find(id);
        }

        public ICollection<TEntity> GetAll()
        {
            return contexto.Set<TEntity>().ToList();
        }

        public ICollection<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return contexto.Set<TEntity>().Where(predicate).ToList();
        }

        public void Update(TEntity obj)
        {
            contexto.Entry(obj).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            contexto.Set<TEntity>().Remove(obj);
            contexto.SaveChanges();
        }
    }
}
