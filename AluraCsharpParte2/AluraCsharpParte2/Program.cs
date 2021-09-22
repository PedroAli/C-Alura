using System;

namespace AluraCsharpParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contapedro = new Conta();
            contapedro.nome = "Pedro Ali";
            Console.WriteLine("saldo da conta do Pedro é de:" + contapedro.saldo);
            contapedro.Depositar(200);
            
            Console.WriteLine("saldo da conta do Pedro é de:" + contapedro.saldo);
            contapedro.Sacar(50);
            Console.WriteLine("saldo da conta do Pedro é de:" + contapedro.saldo);

            Conta contaHenrique = new Conta();
            contaHenrique.nome = "Hernrique Pinto";
            contapedro.Transferir(200,contaHenrique);
        }
    }
}
