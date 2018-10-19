using RestauranteADM.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM
{
    public class senhalogin
    {
     public string recupeçao(string cpf)
        {
            string mensagem;
            Senhar senha = new Senhar();
            return mensagem = senha.recuperaçaosenhar(cpf);
          

        }


    }
}
