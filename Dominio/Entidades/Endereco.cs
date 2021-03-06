﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Enderecos")]
    public class Endereco
    {
        public int Id { get; set; }
        public string _Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
