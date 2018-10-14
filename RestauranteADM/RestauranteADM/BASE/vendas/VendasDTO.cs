using RestauranteADM.BASE.Cardapio;
using RestauranteADM.BASE.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
    public class VendasDTO
    {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public ClienteDTO cliente{ get; set; }
        public CardapioDTO cardapio { get; set; }
    }
}
