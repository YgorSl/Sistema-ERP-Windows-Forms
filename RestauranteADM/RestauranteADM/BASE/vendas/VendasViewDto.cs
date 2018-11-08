using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
    public class VendasViewDto
    {

        public string Nome_cliente { get; set; }
        public int Total { get; set; }
        public DateTime Data { get; set; }

    }
}
