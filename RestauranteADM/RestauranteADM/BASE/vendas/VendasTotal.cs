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
        public double CalcularTaxaEntrega(double valortaxa, double totalfinal)
        {
            double taxa =   valortaxa +totalfinal;
            return taxa;
        }
        public double CalcularTroco(double totalfinal, double valortroco)
        {
            double troco = valortroco - totalfinal;
            troco = Math.Round(troco, 2);

            return troco;
        }

        public double Calcularvalorfinal(double totalfinal, double valortaxa,double percentual)
        {
            double desconto = CalcularDesconto(totalfinal, percentual);
            double taxa = CalcularTaxaEntrega(valortaxa, totalfinal);
            double troco = CalcularTroco(totalfinal, valortaxa);

            double subtotal = totalfinal - desconto;
            double total = subtotal + taxa;
            total = Math.Round(total, 2);

            return total;

            //double valordes = (percentual / 100.0) * totalfinal;
            //double total = valordes + valortaxa;

            //return total;
        }

    }
}
