using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class CompraItemDTO
    {
        public int Id { get; set; }
        public CompraDTO Compra { get; set; }
        public ProdutoDTO Produto { get; set; }
    }
}
