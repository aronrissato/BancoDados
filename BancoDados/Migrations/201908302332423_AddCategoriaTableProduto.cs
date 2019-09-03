namespace BancoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriaTableProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "Categoria", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "Categoria");
        }
    }
}
