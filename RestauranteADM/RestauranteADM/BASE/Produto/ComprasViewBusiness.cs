using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class ComprasViewBusiness
    {
        public List<ComprasView> Filtro(DateTime start, DateTime end)
        {
            ComprasViewDatabase bd = new ComprasViewDatabase();
            List<ComprasView> item = bd.Filtro(start, end);

            return item;
        }
    }
}
