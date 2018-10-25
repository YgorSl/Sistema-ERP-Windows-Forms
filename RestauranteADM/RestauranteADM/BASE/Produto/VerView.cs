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
        public CompraItemDTO IdCompraItem { get; set; }
        public ProdutoDTO IdProduto { get; set; }
        public int Preço { get; set; }
        public string Produto { get; set; }
        public string Fornecedor { get; set; }
    }
}
