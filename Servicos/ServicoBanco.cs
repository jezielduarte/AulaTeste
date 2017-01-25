
using System.Collections.Generic;
using Dominio.Entidades;

namespace Servicos
{
    public class ServicoBanco : ServicoBase<Banco>
    {
        public ICollection<Banco> ConsultaPorDescricao(string descricao)
        {
            return repositorio.Find(x => x.Nome == descricao);
        }
    }
}
