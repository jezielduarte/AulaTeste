using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Runtime.InteropServices;
using Dominio.Entidades;

namespace DAL
{
    public class Contexto : DbContext
    {

        private DbContextTransaction transacao;
        public Contexto() : base(new Config().ConectionString)
        {
            
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        //public DbSet<PlanoDeConta> PlanoDeContas { get; set; }
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Bandeira> Bandeiras { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoVariacoes> ProdutoVariacoes { get; set; }    
        public DbSet<Tamanho> Tamanhos { get; set; }
        public DbSet<Cor> Cores { get; set; }
        public DbSet<Colecao> Colecoes { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Unidade> Unidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

        }

    }
}
