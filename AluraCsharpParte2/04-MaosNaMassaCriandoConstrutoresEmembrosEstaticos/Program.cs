using System;

namespace _04_MaosNaMassaCriandoConstrutoresEmembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(876,12335);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }
    }
}
