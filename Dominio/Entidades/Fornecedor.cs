using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio.Entidades
{
    [Table("Fornecedores")]
    public class Fornecedor : Pessoa
    {
        public string RazaoSocial { get; set; }

        public string CPF { get; set; }

        public string CNPJ { get; set; }

        public string DadosAdicionais { get; set; }
    }
}
