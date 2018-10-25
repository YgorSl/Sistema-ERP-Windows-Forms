using RestauranteADM.BASE.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Estoque
{
    public class Estoque_View
    {
        public int Id { get; set; }
        public CompraDTO IdCompra { get; set; }
        public CompraItemDTO IdCompraItem { get; set; }
        public int IdProduto { get; set; }
        public int Preço { get; set; }
        public string Produto { get; set; }
        public string Fornecedor { get; set; }
    }
}
