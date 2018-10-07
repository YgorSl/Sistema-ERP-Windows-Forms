using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Estoque
{
    class EstoqueDTO
    {
        public int Id { get; set; }
        public DateTime Validade { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public int IdComprasProduto { get; set; }
    }
}
