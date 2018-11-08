using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Conta_a_Pagar
{
    public class ContaPagarBusiness
    {
        public int Salvar(ContaPagarDTO dto)
        {
            ContaPagarDatabase foi = new ContaPagarDatabase();
            int pk = foi.Salvar(dto);
            return pk;

        }
        public void Remover(int id)
        {
            ContaPagarDatabase db = new ContaPagarDatabase();
            db.Remover(id);
        }

        public void Update(ContaPagarDTO dto)
        {
            ContaPagarDatabase db = new ContaPagarDatabase();
            db.Update(dto);

        }
        
    }

}
