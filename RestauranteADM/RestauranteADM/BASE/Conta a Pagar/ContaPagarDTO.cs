using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Conta_a_Pagar
{
    public class ContaPagarDTO
    {

        public int Id { get; set; }
        public string tipo { get; set; }
        public DateTime chegou { get; set; }
        public double Preço { get; set; }
        public DateTime validade { get; set; }

    }
}
