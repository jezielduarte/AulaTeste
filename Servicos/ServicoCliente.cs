
using System.Collections.Generic;
using DAL.Repositorios;
using Dominio.Entidades;

namespace Servicos
{
    public class ServicoFornecedor : ServicoBase<Fornecedor>
    {
        public IEnumerable<Fornecedor> ConsultaPorNome(string nome)
        {
            return repositorio.Find(x => x.Nome == nome);
        }
    }
}
