using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEComerce
{
    public class Categoria
    {
        public string NomeCat { get; set; }
        
        public static int TotalDeCategorias { get; set; } //static?
        
        public Categoria()
        {
            
            TotalDeCategorias++;
        }
    }
}
