using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Cardapio
{
   public  class CardapioDTO
    {
        public int Id { get; set; }
        public string nome_Prato { get; set; }
        public string Descrição { get; set; }
        public string Tamanho { get; set; }
        public double Valor { get; set; }
    }
}
