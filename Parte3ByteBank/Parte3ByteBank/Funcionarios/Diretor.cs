using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte3ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
       
        public Diretor(string cpf) : base(5000,cpf) //herdando argumentos do construtor da classe base funcionario
        {
            Console.WriteLine("Construindo DIRETOR");
        }

        public override double GetBonificacao() // override sobrepoe o metodo virtual
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario * 1.1;
            Salario *= 1.15;
        }
    }
}
