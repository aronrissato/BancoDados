using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados.DAL;
using BancoDados.Models;

namespace BancoDados.Views
{
    class BuscarParteProduto
    {

        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine(" -- BUSCAR PRODUTO --\n");
            Console.WriteLine("Informe o nome do produto: ");
            p.Nome = Console.ReadLine();

            foreach (Produto item in ProdutoDAO.BuscarProdutosPorParteNome(p))
            {
                Console.WriteLine(item);
            }

        }
    }
}