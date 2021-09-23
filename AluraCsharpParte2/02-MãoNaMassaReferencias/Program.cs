using System;

namespace _02_MãoNaMassaReferencias
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaCamila = new ContaCorrente();
            contaDaCamila.titular = new Cliente();
            contaDaCamila.titular.nome = "Camila";
        }
    }
}
