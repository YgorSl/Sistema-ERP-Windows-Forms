using RestauranteADM.BASE.Fornecedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class CompraDTO
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public FornecedorDTO Forneceddor { get; set; }
    }
}
