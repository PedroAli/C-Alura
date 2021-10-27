using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEComerce
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listaProdutos = new List<Produto>(); //<--- Lista de produtos
            
            listaProdutos.Add(new Produto ("Cerveja")// <-- instancia o obj e já o adiciona na lista
            {
                Valor = 5.40,
                NomeCat = "Bebiada",
                NomeSubCat = "Alimentação",
                Peso = 250,
                Altura = 15,
                Largura = 8,
                Comprimento = 5,
                QuantidaeEmEstoque = 10,
                Status = 1

            });

            Produto fone = new Produto("Headphone"); // <-- instancia o obj 
            fone.NomeCat = "computaçao";
            fone.NomeSubCat = "Eletronico";
            fone.Valor = 2;
            fone.Peso = 200;
            fone.Altura = 10.5;
            fone.Largura = 4;
            fone.Comprimento = 12;
            fone.QuantidaeEmEstoque = 100;
            fone.Status = 1;
            //Console.WriteLine("Main Nome do produto " + fone.NomeDoProduto);
                      

           Produto novoproduto = new Produto("Novo");
           novoproduto.NomeCat = "computaçao";
           novoproduto.NomeSubCat = "Eletronico";
           novoproduto.Valor = 800;
           novoproduto.Peso = 450;
           novoproduto.Altura = 55.5;
           novoproduto.Largura = 8;
           novoproduto.Comprimento = 50;
           novoproduto.QuantidaeEmEstoque = 9;
           novoproduto.Status = 0;
           //Console.WriteLine("Main Nome do produto " + novoproduto.NomeDoProduto);

            //--------Chama os métodos aqui---------//

            CadastrarProduto(fone, novoproduto); // cadastrar mais de um param ????

            GerarListaDeProdutos();

            //listaProdutos.RemoveAt(0); // <---remove pelo índice

            //listaProdutos.Remove(novoproduto); // <---remove pelo nome do obj

            //SubstituirCategoria(fone,"novaCat");

            //GerarListaDeProdutos();

            //ProcurarProdutoNome("Nov");

            //ListarProdutosPorStatus();

            //OrdenarProdutoValorStatus();


            //--------Métodos---------//

            // Find all computer books.
            void ListarProdutosPorStatus()
            {
                List<Produto> results = listaProdutos.FindAll(FindStatus);
                if (results.Count != 0)
                {
                    DisplayResults(results, "Produtos Ativos:");
                }
                else
                {
                    Console.WriteLine("\nNo Products found.");
                }
            }


            void OrdenarProdutoValorStatus()
            {
                var listaOrdenadaPorTipo = listaProdutos.Where(produtol => produtol.Status != 0)
                 .OrderBy(produtol => produtol.Valor);

                foreach (var produtol in listaOrdenadaPorTipo)
                {
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine($"{produtol.NomeDoProduto} com valor de {produtol.Valor} ordenado por Valor teste");
                }
            }
           

             void ProcurarProdutoNome(string procuraProdutoPeloNome)
             {
                
                Produto result = listaProdutos.Find(
                  delegate (Produto bk)
                  {
                      return bk.NomeDoProduto == procuraProdutoPeloNome;
                      
                  }
                  );
                if (result != null)
                {
                    Console.WriteLine("O produto: " + procuraProdutoPeloNome + " foi encontrado"); //"\nNot found: {0}", procuraProdutoPeloNome
                }
                else 
                {
                    Console.WriteLine("Produto: " + procuraProdutoPeloNome + " Não encontrado");
                }
             } 
           

            void GerarListaDeProdutos()
            {
                foreach (Produto oProd in listaProdutos)
                {
                    oProd.MostrarListaDeProdutos();
                }
            }


            void CadastrarProduto(params Produto[] produtos)
            {
                foreach (var produto in produtos)
                {
                    listaProdutos.Add(produto);  //---> listaProdutos.AddRange(produtos); faz o mesmo sem o foreach
                }
                
            }

            void SubstituirCategoria(Produto prod, string novaCategoria)
            {
                prod.NomeCat = novaCategoria;
                Console.WriteLine($"Categoria {novaCategoria} atualizada no produto: {prod.NomeDoProduto}");
            }

            void SubstituirSubCategoria(Produto prod, string novasubCategoria)
            {
                prod.NomeSubCat = novasubCategoria;
                Console.WriteLine($"Subcategoria {novasubCategoria} atualizada no produto {prod.NomeDoProduto}");
            }




            static void DisplayResult(Produto result, string title)
            {
                Console.WriteLine();
                Console.WriteLine(title);
                Console.WriteLine("\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}", result.NomeDoProduto,
                    result.IDProduto, result.Status, result.Valor);
                Console.WriteLine();
            }


            static void DisplayResults(List<Produto> results, string title)
            {
                Console.WriteLine();
                Console.WriteLine(title);
                foreach (Produto b in results)
                {

                    Console.WriteLine($"{b.NomeDoProduto} , ID: {b.IDProduto} , Status {b.Status} , Valor {b.Valor}");

                }
                Console.WriteLine();
            }



            static bool FindStatus(Produto bk)
            {

                if (bk.Status == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            Console.ReadKey();


        }
    }
}
