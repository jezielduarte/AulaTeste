
using System.Collections.Generic;
using Dominio.Entidades;

namespace Servicos
{
    public class ServicoBandeira : ServicoBase<Bandeira>
    {
        public ICollection<Bandeira> ConsultaPorDescricao(string descricao)
        {
            return repositorio.Find(x => x.Descricao == descricao);
        }
    }
}
