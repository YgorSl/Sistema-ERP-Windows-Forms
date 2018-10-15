using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
 public    class VendasViewBunisess
    {


        public List<VendasViewDto> Filtro(DateTime start, DateTime end)
        {
          VendasViewDatabase bd = new VendasViewDatabase();
            List<VendasViewDto> item = bd.Filtro(start, end);

            return item;
        }
    }
}
