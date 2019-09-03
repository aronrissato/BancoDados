using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados.Models;
using BancoDados.DAL;

namespace BancoDados.Views
{
    class RemoverProduto
    {
        public static void Renderizar()
        {
            try
            {
                Produto p = new Produto();
                Console.WriteLine("-- REMOVE PRODUTO --");
                Console.WriteLine("Informe o id do produto que deseja remover");
                p.ProdutoId = Convert.ToInt32(Console.ReadLine());
                p = ProdutoDAO.BuscarProdutoPorNome(p);

                if (p == null)
                {
                    throw new Exception("Produto não encontrado!.");
                }
                ProdutoDAO.RemoverProduto(p);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}