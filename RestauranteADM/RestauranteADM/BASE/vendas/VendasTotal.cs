using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
    public class VendasTotal
    {
        public double CalcularDesconto (double valorprodutos, double percentual)
        {
            double desconto = (percentual / 100.0) * valorprodutos;
            desconto = Math.Round(desconto, 2);

            return desconto;
        }
        public double CalcularTaxaEntrega(double valortaxa, double totalfinal)
        {
            double taxa = valortaxa + totalfinal ;
            taxa = Math.Round(taxa, 2);

            return taxa;
        }
        public double CalcularTroco(double totalfinal, double valortroco)
        {
            double troco = valortroco - totalfinal;
            troco = Math.Round(troco, 2);

            return troco;
        }
    }
}
