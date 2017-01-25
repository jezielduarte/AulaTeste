
using System.Collections.Generic;
using Dominio.Entidades;

namespace Servicos
{
    public class ServicoCartao : ServicoBase<Cartao>
    {
        public ICollection<Cartao> ConsultaPorDescricao(string descricao)
        {
            return repositorio.Find(x => x.Descricao == descricao);
        }
    }
}
