using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.FluxoDeCaixa
{
  public  class FluxodecaixaBunisess
    {

        public List<FluxodecaixaDTO> filtro(DateTime start, DateTime end)
        {
            FluxodecaixaDatabase db = new FluxodecaixaDatabase();
           List< FluxodecaixaDTO> dados=db.Filtro(start, end);
            return dados;
        }
    }
}
