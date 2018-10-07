using RestauranteADM.BASE.Fornecedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preço { get; set; }
        public decimal Quantidade { get; set; }
        public FornecedorDTO Fornecedor{ get; set; }
    }
}
