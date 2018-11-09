using RestauranteADM.BASE.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Folha_de_Pagamento
{
   public class FolhaPagamentoDTO
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public double SalarioBase { get; set; }
        public double HE { get; set; }
        public double Convenio { get; set; }
        public double DSR{ get; set; }
        public double VR { get; set; }
        public double VT { get; set; }
        public double SalarioFamilia { get; set; }
        public double Bonus { get; set; }
        public double Atraso { get; set; }
        public double Falta { get; set; }
        public double CestaBasica { get; set; }
        public double INSS { get; set; }
        public double IRRF { get; set; }
        public double FGTS { get; set; }
        public double SalarioLiquido { get; set; }

        public string Nome { get; set; }

        public string Data { get; set; }

        public string CPF { get; set; }

        public FuncionarioDTO funcio { get; set; }


    }
}
