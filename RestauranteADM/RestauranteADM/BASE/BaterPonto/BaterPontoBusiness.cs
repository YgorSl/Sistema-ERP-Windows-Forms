using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.BaterPonto
{
    public class BaterPontoBusiness

    {

        

            public void verificar(string cpf)
        {

            BaterPontoDatabase database = new BaterPontoDatabase();
            database.Consultar(cpf);
           

        }
        public int Salvar(BaterPontoDTO dto)
        {
            BaterPontoDatabase database = new BaterPontoDatabase();
            int pk = database.Salvar(dto);
            return pk;

        }
    }
}
