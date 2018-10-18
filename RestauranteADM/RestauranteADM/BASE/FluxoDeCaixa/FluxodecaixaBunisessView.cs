using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.FluxoDeCaixa
{
  public  class FluxodecaixaBunisessView
    {

        public List<FluxodecaixaView> filtro(DateTime start, DateTime end)
        {
            FluxodecaixaDatabaseView db = new FluxodecaixaDatabaseView();
            List<FluxodecaixaView> dados=db.Filtro(start, end);
            return dados;
        }
    }
}
