using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE
{
    public class senharlogin
    {
 
       public string recuperaçao(string dni)
        {
            string mensagem;
            Senhar senha = new Senhar();
             mensagem = senha.recuperaçaosenhar(dni);
            return mensagem;

        }



    }
}
