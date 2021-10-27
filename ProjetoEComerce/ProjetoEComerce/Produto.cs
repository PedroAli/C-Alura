using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoEComerce
{
    class Produto : SubCategoria
    {
        public string NomeDoProduto { get; set; } // pq tirar o Set faz dar certo no construtor??? ---- set = _nomeDoProduto = value;
        public double Valor { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public int QuantidaeEmEstoque { get; set; }
        public double Comprimento { get; set; }
        public string DescricaoDoProduto { get; set; }

        //Centro de destribuição

        DateTime DataAtual = DateTime.Now;
        public static int ToTaldeProdutos { get; set; } //static?
        public int Status { get; set; }
        public  Guid IDProduto { get; set; }
        public Produto(string nomeDoProduto)
        {
            
            NomeDoProduto = nomeDoProduto;
            Status = 1;
            IDProduto = Guid.NewGuid();
            ToTaldeProdutos++;
            //Console.WriteLine("CONSTRUTOR nome do produto" + this.NomeDoProduto);
            //Console.WriteLine("CONSTRUTOR ID" + IDProduto);
        }
        public  void MostrarListaDeProdutos()
        {
            
            if (this.Status == 1)
            {
                Console.WriteLine("Produto: " + this.NomeDoProduto);
                Console.WriteLine("Status: Ativo");
                Console.WriteLine("ID" + this.IDProduto); //??????
                Console.WriteLine("Valor: " + this.Valor + "Reais");
                Console.WriteLine("Peso: " + this.Peso + " Gramas");
                Console.WriteLine("Altura: " + this.Altura + " Cm");
                Console.WriteLine("Largura: " + this.Largura + " Cm");
                Console.WriteLine("Comprimento: " + this.Comprimento + " Cm");
                Console.WriteLine("QuantidadeEmEstoque: " + this.QuantidaeEmEstoque);
                Console.WriteLine("ToTaldeProdutos: " + ToTaldeProdutos);
                Console.WriteLine("Adicionado em: " + this.DataAtual);
                Console.WriteLine("Categoria: " + this.NomeCat);
                Console.WriteLine("Subcategoria: " + this.NomeSubCat);
                Console.WriteLine("***********************************");
            }
            else
            {
                Console.WriteLine("Status: Inativo");
            }
           
        }




    }
}
