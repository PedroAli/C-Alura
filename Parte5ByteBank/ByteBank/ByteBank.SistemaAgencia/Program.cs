using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(374, 3627362);
            Console.WriteLine(conta.Numero);

            // Dia 17 de Agosto de 2018
            DateTime dataFimPagamento = new DateTime(2018, 8, 17);
            // Data corrente no momento de execução do código
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataCorrente;
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
    }
}
