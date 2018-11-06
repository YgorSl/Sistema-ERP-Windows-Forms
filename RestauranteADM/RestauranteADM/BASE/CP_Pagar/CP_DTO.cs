using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.CP_Pagar
{
    public class CP_DTO
    {
        public int Id { get; set; }
        public string Prestador { get; set; }
        public DateTime chegou { get; set; }
        public double Valor { get; set; }
        public DateTime vencimento { get; set; }
        public string Prazo { get; set; }
        public string Documento { get; set; }
        public string Operacao { get; set; }
        public int Conta { get; set; }
        public int Agencia { get; set; }
        public string Banco { get; set; }
        public bool ok { get; set; }
    }
}
