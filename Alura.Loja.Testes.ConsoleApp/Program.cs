using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //GravarUsandoEntity();
            //RecuperarProdutosEntity();
            //ExcluirProdutos();
            // RecuperarProdutosEntity();
            AtualizarProduto();

        }

        private static void AtualizarProduto()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                Produto primeiro = repo.Produtos().First();
                primeiro.Nome = "Harry potter e a ordem da Fenix ( EDITADO )";
                repo.Atualizar(primeiro);
               
            }

            RecuperarProdutosEntity();

            Console.ReadLine();
        }

        private static void ExcluirProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos();

                foreach (var item in produtos)
                {
                    repo.Remover(item);
                }
                Console.ReadLine();
            }
        }

        private static void RecuperarProdutosEntity()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                Console.WriteLine("Foram encontrados {0} produto(s) ", produtos.Count);
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
                Console.ReadLine();
            }

        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            Produto p1 = new Produto();
            p.Nome = "Harry Potter e a Pedra Filosofal";
            p.Categoria = "Livros";
            p.Preco = 25.90;

            using (var context = new ProdutoDAOEntity())
            {
                context.Adicionar(p);
                
            }

            Console.ReadLine();
        }

        //private static void GravarUsandoAdoNet()
        //{
        //    Produto p = new Produto();
        //    p.Nome = "Harry Potter e a Ordem da Fênix";
        //    p.Categoria = "Livros";
        //    p.Preco = 19.89;

        //    using (var repo = new ProdutoDAO())
        //    {
        //        repo.Adicionar(p);
        //    }
        //}
    }
}
