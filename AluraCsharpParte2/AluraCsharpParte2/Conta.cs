using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraCsharpParte2
{
    class Conta
    {
        public double saldo = 100;
        public int agencia;
        public string nome;
        

        public void Depositar (double valor)
        {
            
            this.saldo += valor;
            Console.WriteLine("foi depositado " + valor + " reais na conta de" + this.nome);
        }

        public bool Sacar (double valor)
        {
            
            if (this.saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }

            this.saldo -= valor;
            Console.WriteLine(valor + " reais sacados");
            return true;
        }

        public bool Transferir (double valor, Conta contaDestino)
        {
            
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
