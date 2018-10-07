using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Conta_a_Pagar
{
    class ContaPagarDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdCompraProduto { get; set; }
        public int idFolhaPagamento { get; set; }
        public double Preço { get; set; }
    }
}
