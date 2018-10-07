using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.BaterPonto
{
    class BaterPontoDTO
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public DateTime Data { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime IdaAlmoço { get; set; }
        public DateTime VoltaAlmoço { get; set; }
        public DateTime Saida { get; set; }
        public DateTime HorasExtras { get; set; }
    }
}
