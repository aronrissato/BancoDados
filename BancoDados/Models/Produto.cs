using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados.DAL;
using BancoDados.Models;
using BancoDados.Views;

namespace BancoDados.Models
{
    [Table("Produtos")]

    class Produto
    {
        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int ProdutoId { get; set; }

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }
        //FK na tabela produto = Categoria. Quando criar nova variavel com o tipo de uma classe
        //é criado automatico o relacionamento \/
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return "idProduto: " + ProdutoId + "Produto: " + Nome + " | Preço: " + Preco.ToString("C2");
        }
    }
}
