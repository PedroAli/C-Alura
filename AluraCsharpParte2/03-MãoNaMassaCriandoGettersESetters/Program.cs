using System;

namespace _03_MãoNaMassaCriandoGettersESetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ContaCorrente Conta1 = new ContaCorrente();
            Conta1.Agencia = 4;
            Conta1.Saldo += 50;
            Console.WriteLine(Conta1.Saldo);
        }
    }
}
