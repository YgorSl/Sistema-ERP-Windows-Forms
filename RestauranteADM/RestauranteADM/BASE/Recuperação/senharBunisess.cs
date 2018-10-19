using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE
{
    public class senharBunisess
    {
 
       public string recuperaçao(string Recuperacao)
        {
             string mensagem;
             Senhar senha = new Senhar();
             mensagem = senha.recuperaçaosenhar(Recuperacao);
             return mensagem;
        }



    }
}
