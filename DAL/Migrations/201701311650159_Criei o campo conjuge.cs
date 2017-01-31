namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Crieiocampoconjuge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empregados", "Conjuge", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empregados", "Conjuge");
        }
    }
}
