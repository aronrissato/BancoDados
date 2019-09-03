using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Models
{
    //Herdar da classe DBContext

    class Context : DbContext
    {
        //Nomear o banco de dados
        public Context() : base("DbProdutos") { }

        //Definir as classes que vão virar tabelas no banco
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
