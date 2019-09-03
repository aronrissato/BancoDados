using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados.DAL;
using BancoDados.Models;

namespace BancoDados.Views
{
    class BuscarProduto
    {
        public static void Renderizar()
        {
            try
            {
                Produto p = new Produto();
                Console.WriteLine(" -- BUSCAR PRODUTO --\n");
                Console.WriteLine("Informe o nome do produto: ");
                p.Nome = Console.ReadLine();
                p = ProdutoDAO.BuscarProdutoPorNome(p);


                if (p == null)
                {
                    throw new Exception("\nProduto não existe!");
                }
                Console.WriteLine(p);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

    }
}
