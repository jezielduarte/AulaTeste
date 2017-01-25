
using System.Collections.Generic;
using DAL.Repositorios;

namespace Servicos
{
    public class ServicoBase<TEntity> where TEntity : class
    {

        protected RepositorioBase<TEntity> repositorio;

        public ServicoBase()
        {
            repositorio = new RepositorioBase<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            repositorio.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return repositorio.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repositorio.GetAll();
        }

        public virtual void Update(TEntity obj)
        {
            repositorio.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            repositorio.Remove(obj);
        }
    }
}
