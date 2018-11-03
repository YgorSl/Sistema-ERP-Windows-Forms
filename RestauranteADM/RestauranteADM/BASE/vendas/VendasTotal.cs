using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
    public class VendasTotal
    {
        public double CalcularDesconto (double totalfinal, double percentual)
        {
            double desconto = (percentual / 100.0) * totalfinal;
            desconto = Math.Round(desconto, 2);

            return desconto;
        }
       

    }
}
