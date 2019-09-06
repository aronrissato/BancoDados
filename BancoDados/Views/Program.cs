using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados.DAL;
using BancoDados.Models;
using BancoDados.Views;

namespace Views.BancoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ResetColor();
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  -- PROJETO BANCO DE DADOS --  \n");
                Console.ResetColor();
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Buscar produto por nome");
                Console.WriteLine("4 - Buscar produto por parte do nome");
                Console.WriteLine("5 - Alterar produto");
                Console.WriteLine("6 - Remover produto");
                Console.WriteLine("7 - Cadastrar categoria");
                Console.WriteLine("8 - Buscar categoria por nome");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite uma opção:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        CadastrarProduto.Renderizar();
                        break;
                    case 2:
                        ListarProdutos.Renderizar();
                        break;
                    case 3:
                        BuscarProduto.Renderizar();
                        break;
                    case 4:
                        BuscarParteProduto.Renderizar();
                        break;
                    case 5:
                        //AlterarProduto.Renderizar();
                        break;
                    case 6:
                        RemoverProduto.Renderizar();
                        break;
                    case 7:
                        //RemoverProduto.Renderizar();
                        break;
                    case 8:
                        BuscarCategoria.Renderizar();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("\n\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

    }
}
