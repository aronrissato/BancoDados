using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados.Models;
using BancoDados.DAL;

namespace BancoDados.DAL
{
    class CategoriaDAO
    {
        private static Context ctx = new Context();

        public static Categoria CadastrarCategoria(Categoria c)
        {
            return CadastrarCategoria(c);
        }


        public static Categoria BuscarCategoriaPorNome(Categoria c)
        {
            return ctx.Categorias.FirstOrDefault(x => x.Nome.Contains(c.Nome));
        }         
    }
}
