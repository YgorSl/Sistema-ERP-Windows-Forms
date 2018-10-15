using RestauranteADM.BASE.Cardapio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
   public class vendas_item_DTO
    {

        public int Id { get; set; }
        public VendasDTO vendas { get; set; }
        public CardapioDTO cardapio { get; set; }
    }
}
