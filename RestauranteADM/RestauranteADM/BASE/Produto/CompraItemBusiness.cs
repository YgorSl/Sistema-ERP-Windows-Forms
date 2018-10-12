using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class CompraItemBusiness
    {
        public void Salvar(CompraItemDTO item)
        {
            CompraItemDatabase db = new CompraItemDatabase();
            db.Salvar(item);
        }
        
    }
}
