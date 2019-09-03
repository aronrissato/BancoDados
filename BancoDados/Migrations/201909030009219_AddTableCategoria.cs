namespace BancoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categorias");
        }
    }
}
