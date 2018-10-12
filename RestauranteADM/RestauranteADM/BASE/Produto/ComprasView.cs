using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class ComprasView
    {
        public string Nome { get; set; }
        public int Total { get; set; }
        public int Qtd { get; set; }
        public DateTime  Data { get; set; }
    }
}
