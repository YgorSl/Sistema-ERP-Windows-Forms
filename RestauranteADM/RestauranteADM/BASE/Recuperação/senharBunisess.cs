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
        Senhar senha = new Senhar();

        public string recuperaçao(string Recuperacao)
        {
             string mensagem;
             mensagem = senha.recuperaçaosenhar(Recuperacao);
             return mensagem;
        }



    }
}
