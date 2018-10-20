using RestauranteADM.BASE.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Estoque
{
    public class EstoqueDTO
    {
        public int Id { get; set; }
        public ProdutoDTO Produto { get; set; }
        public CompraItemDTO CompraItem{ get; set; }
        
    }
}
