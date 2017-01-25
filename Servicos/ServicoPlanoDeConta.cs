
using System.Collections.Generic;
using Dominio.Entidades;

namespace Servicos
{
    public class ServicoPlanoDeConta : ServicoBase<PlanoDeConta>
    {
        public ICollection<PlanoDeConta> ConsultaPorDescricao(string descricao)
        {
            return repositorio.Find(x => x.Descricao == descricao);
        }
    }
}
