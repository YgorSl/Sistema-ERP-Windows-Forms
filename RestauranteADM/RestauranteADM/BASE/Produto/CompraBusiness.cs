using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    class CompraBusiness
    {
        public void Salvar(CompraDTO compra, List<CompraItemDTO> Itens)
        {
            CompraDatabase db = new CompraDatabase();
            int id = db.Salvar(compra);

            CompraItemBusiness item = new CompraItemBusiness();

            foreach (CompraItemDTO itemc in Itens)
            {
                itemc.Compra = new CompraDTO();
                itemc.Compra.Id = id;

                item.Salvar(itemc);
            }

        }
        public List<CompraDTO> filtro(DateTime start, DateTime end)
        {
            CompraDatabase db = new CompraDatabase();
            List<CompraDTO> compras = db.filtro(start, end);

            return compras;
        }
    }
}
