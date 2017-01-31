using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Runtime.InteropServices;
using Dominio.Entidades;

namespace DAL
{
    public class Contexto : DbContext
    {
        private DbContextTransaction transacao;
        public Contexto()
            : base("Persist Security Info=False;User ID=sa;pwd=dba@alpha;Initial Catalog=Banco;Data Source=Prog02-PC")
        {
            
        }

        public void BeginTran()
        {
            transacao = Database.BeginTransaction();
        }
        public void CommitTran()
        {
            transacao.Commit();
        }
        public void RollBackTran()
        {
            transacao.Rollback();
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
