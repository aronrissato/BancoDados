using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados.Models;
using BancoDados.DAL;


namespace BancoDados.Views
{
    class BuscarCategoria
    {
        public static void Renderizar()
        {
            Categoria c = new Categoria();
            Console.WriteLine("-- BUSCAR CATEGORIA --");
            Console.WriteLine("Informe o nome da categoria que deseja: \n");
            c.Nome = Console.ReadLine();
            c = CategoriaDAO.BuscarCategoriaPorNome(c);

            if (c != null)
            {
                Console.WriteLine($"\n{c.CategoriaId} {c.Nome}");
            }
        }
    }
}
