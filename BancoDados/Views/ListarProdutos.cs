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
    class ListarProdutos
    {
        public static void Renderizar()
        {
            Console.WriteLine("  -- LISTAR PRODUTOS --  \n");
            foreach (Produto produtoCadastrado in ProdutoDAO.ListarProdutos())
            {
                Console.WriteLine(produtoCadastrado);
            }
        }
    }
}
