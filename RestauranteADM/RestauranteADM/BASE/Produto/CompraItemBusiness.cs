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
        public List<CompraItemDTO> Filtro(int CompraId)
        {
            CompraItemDatabase db = new CompraItemDatabase();
            List<CompraItemDTO> items = db.Filtro(CompraId);
            return items;
        }
    }
}
