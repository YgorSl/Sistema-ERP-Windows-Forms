using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.CP_Pagar
{
    public class CP_Business
    {


        public int Salvar(CP_DTO dto)
        {
            CP_Database foi = new CP_Database();
            int pk = foi.Salvar(dto);
            return pk;

        }
        public void Remover(int id)
        {
            CP_Database db = new CP_Database();
            db.Remover(id);
        }

    

      


    }
}
