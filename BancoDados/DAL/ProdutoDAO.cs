using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados.DAL;
using BancoDados.Models;
using BancoDados.Views;

namespace BancoDados.DAL
{
    class ProdutoDAO
    {
        //Any() informa se há registros dentro da tabela
        //Count() informa a quantidade de registros dentro da tabela

        private static Context ctx = new Context();
        public static void CadastrarProduto(Produto p)
        {
            ctx.Produtos.Add(p);
            ctx.SaveChanges();
        }

        public static List<Produto> ListarProdutos() => ctx.Produtos.ToList();

        public static Produto BuscarProdutoPorNome(Produto p)
        {
            //Método FirstOrDefault: retorna sempre UM objeto na busca(o primeiro da consulta).
            return ctx.Produtos.FirstOrDefault(x => x.Nome.Equals(p.Nome));

            //return ctx.Produtos.SingleOrDefault(x => x.Nome.Equals(p.Nome));
        }

        public static List<Produto> BuscarProdutosPorParteNome(Produto p)
        {
            return ctx.Produtos.Where(x => x.Nome.Contains(p.Nome)).ToList();
        }

        public static double CalcularValorEstoque()
        {
            return ctx.Produtos.Sum(x => x.Quantidade * x.Preco);
        }

        public static void RemoverProduto(Produto p)
        {
            ctx.Produtos.Remove(p);
            ctx.SaveChanges();
        }

        public static void AlterarProduto(Produto p)
        {
            ctx.Entry(p).State = EntityState.Modified;
            ctx.SaveChanges();
        }

    }
}
