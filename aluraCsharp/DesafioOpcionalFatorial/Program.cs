using System;

namespace DesafioOpcionalFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            for (int i = 1; i <= 6; i++)
            {
                n = n * i;
                Console.WriteLine(n);
                Console.WriteLine("Fatorial de " + i + " = " + n);
            }
        }
    }
}
