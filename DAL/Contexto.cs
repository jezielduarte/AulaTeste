using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=BancoAula;Data Source=(local)")
        {
                
        }

        //public DbSet<> Type { get; set; }

    }
}
