using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
    public class VendasBunisess
    {
        public void Salvar(VendasDTO dto)
        {
            VendasDatabase db = new VendasDatabase();
            db.Salvar(dto);
        }
    }
}
