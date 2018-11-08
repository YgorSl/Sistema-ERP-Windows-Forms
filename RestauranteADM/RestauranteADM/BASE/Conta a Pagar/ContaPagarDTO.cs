using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Conta_a_Pagar
{
    public class ContaPagarDTO
    {

        public int Id { get; set; }
        public string tipo_cobrança { get; set; }
        public string conta_contabil { get; set; }
        public string conta_contabil_ds { get; set; }
        public string conta { get; set; }
        public string agencia { get; set; }
        public string banco { get; set; }
        public string observaçao { get; set; }
        public DateTime emissao { get; set; }
        public DateTime data_cadastro { get; set; }
        public DateTime vencimento { get; set; }
        public double valor_titulo { get; set; }
        public int parcelados { get; set; }

        public string Prestador { get; set; }
        public string Cnpj { get; set; }
        public double valor_parcelas { get; set; }



        public bool pagou { get; set; }





    }
}
