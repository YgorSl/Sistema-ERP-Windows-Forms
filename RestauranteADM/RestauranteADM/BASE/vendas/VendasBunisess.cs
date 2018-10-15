using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
    public class VendasBunisess
    {
        public void Salvar(VendasDTO vendas, List<vendas_item_DTO> item)
        {
            VendasDatabase db = new VendasDatabase();
            int id = db.Salvar(vendas);

            Vendas_Item_Bunisess itens = new Vendas_Item_Bunisess();

            foreach (vendas_item_DTO ite in item)
            {
                ite.vendas = new VendasDTO();
                ite.vendas.Id = id;

                itens.Salvar(ite);
            }
        }
    }
}
