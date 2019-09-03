using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados.DAL;
using BancoDados.Models;
using BancoDados.Views;

namespace BancoDados.Views
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Categoria c = new Categoria();
            Console.WriteLine("  -- CADASTRAR PRODUTO --  \n");
            Console.WriteLine("Digite o nome do produto:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade do produto:");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto:");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            ProdutoDAO.CadastrarProduto(p);

            Console.WriteLine("Digite o nome da categoria:");
            c.Nome = Console.ReadLine();
            c = CategoriaDAO.BuscarCategoriaPorNome(c);
            if (c != null)
            {
                p.Categoria = c;
                ProdutoDAO.CadastrarProduto(p);
                Console.WriteLine("Produto cadastrado!");
            }
            else
            {
                Console.WriteLine("Essa categoria não existe!");
            }
        }
    }
}
