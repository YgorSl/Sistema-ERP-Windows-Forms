using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
    public class Vendas_Item_Bunisess
    {

        
            public void Salvar(Vendas_Item_Bunisess dto)
        {
            Vendas_Item_Bunisess db = new Vendas_Item_Bunisess();
            db.Salvar(dto);
        }
    }
    }

