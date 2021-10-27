using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEComerce
{
    public class SubCategoria : Categoria
    {
        public string NomeSubCat { get; set; }

        public static int TotalDeSubCategorias { get; set; } //static?
        
       
    }
}
