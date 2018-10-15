using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
    public class Vendas_Item_Bunisess
    {

        
          public void Salvar(vendas_item_DTO item)
        {
            Vendas_Item_Database db = new Vendas_Item_Database();
            db.Salvar(item);
        }
    }
    }

