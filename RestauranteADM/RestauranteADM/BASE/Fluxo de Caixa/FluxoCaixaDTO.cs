using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Fluxo_de_Caixa
{
   public class FluxoCaixaDTO
    {
        public int Id { get; set; }

        public DateTime Perido_inicial { get; set; }
        public DateTime Perido_final { get; set; }
        public double ganhor { get; set; }
        public double perdar { get; set; }
        public float saldo { get; set; }
   
    }
}
