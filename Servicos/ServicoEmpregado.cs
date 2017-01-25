
using System.Collections.Generic;
using Dominio.Entidades;

namespace Servicos
{
    public class ServicoEmpregado : ServicoBase<Empregado>
    {
        #region  Forma Luzitana <Comentado>
       /*
        * Forma Luzitana
        * 
        public override void Add(Fornecedor obj)
        {
            //Criando um contexto para que todas as operações participem da mesma transação
            Contexto contexto = new Contexto();
            try
            {
                
                //Abrindo a transação
                contexto.RollBackTran();

                // O metodo add do repositorio de fornecedor retorna o fornecedor inserido no banco
                Fornecedor fornecedor = repositorio.Add(obj);

                //Criando um repositorio de telefone para inserir os telefones do fornecedor
                RepositorioTelefone repTelefone = new RepositorioTelefone();
                foreach (Telefone telefone in obj.Telefones)
                {
                    telefone.PessoaId = fornecedor.Id;
                    repTelefone.Add(telefone);
                }

                //Criando um repositorio de telefone para inserir os endereços do fornecedor
                RepositorioEndereco repEndereco = new RepositorioEndereco();
                foreach (Endereco endereco in obj.Enderecos)
                {
                    endereco.PessoaId = fornecedor.Id;
                    repEndereco.Add(endereco);
                }
                contexto.CommitTran();
            }
            catch (Exception e)
            {
                contexto.RollBackTran();
                throw new Exception("Ocorreu um erro ao gravar o fornecedor!!!\n" + e.Message);
            }
            finally
            {
                contexto.Dispose();
            }
        }
        */ 
        #endregion

        public ICollection<Empregado> ConsultaPorNome(string nome)
        {
            return repositorio.Find(x => x.Nome == nome);
        }
    }
}
