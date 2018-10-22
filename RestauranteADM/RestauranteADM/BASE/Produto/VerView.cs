using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class VerView
    {
        public int IdCompra { get; set; }
        public int IdCompraItem { get; set; }
        public int Preço { get; set; }
        public string Produto { get; set; }
        public string Fornecedor { get; set; }
    }
}
