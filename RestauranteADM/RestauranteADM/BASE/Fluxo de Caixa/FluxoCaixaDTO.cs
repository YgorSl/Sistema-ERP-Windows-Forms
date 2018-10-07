using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Fluxo_de_Caixa
{
    class FluxoCaixaDTO
    {
        public int Id { get; set; }
        public int IdVendaPrato { get; set; }
        public int ContaPagar { get; set; }
    }
}
