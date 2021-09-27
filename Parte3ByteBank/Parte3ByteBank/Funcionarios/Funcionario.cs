using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte3ByteBank.Funcionarios
{
    public abstract class Funcionario // A classe é uma abstracao e não deve ser diretamente instanciado
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario( double salario,string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios ++;
            Console.WriteLine("Construtor de FUNCIONARIO");
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao(); //pode ser sobrecarregado 
        
    }
}
