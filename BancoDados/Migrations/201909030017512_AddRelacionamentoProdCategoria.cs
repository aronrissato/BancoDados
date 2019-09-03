namespace BancoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelacionamentoProdCategoria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "Categoria_CategoriaId", c => c.Int());
            CreateIndex("dbo.Produtos", "Categoria_CategoriaId");
            AddForeignKey("dbo.Produtos", "Categoria_CategoriaId", "dbo.Categorias", "CategoriaId");
            DropColumn("dbo.Produtos", "Categoria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtos", "Categoria", c => c.String());
            DropForeignKey("dbo.Produtos", "Categoria_CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtos", new[] { "Categoria_CategoriaId" });
            DropColumn("dbo.Produtos", "Categoria_CategoriaId");
        }
    }
}
