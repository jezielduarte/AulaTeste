
using System.Collections.Generic;
using Dominio.Entidades;

namespace Servicos
{
    public class ServicoCliente : ServicoBase<Cliente>
    {
        public ICollection<Cliente> ConsultaPorNome(string nome)
        {
            return repositorio.Find(x => x.Nome == nome);
        }
    }
}
