using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados.DAL;
using BancoDados.Models;

namespace BancoDados.Views
{
    class CadastrarCategoria
    {
        public static void Renderizar()
        {
            Categoria c = new Categoria();
            Console.WriteLine("-- CADASTRAR CATEGORIA --");
            Console.WriteLine("\nInforme o nome da categoria que deseja cadastrar:\n");
            c.Nome = Console.ReadLine();

            if (c.Nome != null)
            {
                c = CategoriaDAO.CadastrarCategoria(c);
            }
        }
    }
}
