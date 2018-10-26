using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Recuperação
{
  public  class AlteraçaoBunisess
    {

            AlteracaoLogin senha = new AlteracaoLogin();

            public string recuperaçao(string Recuperacao)
            {
                string mensagem;
                mensagem = senha.recuperaçaosenhar(Recuperacao);
                return mensagem;
            }

        public void verificacao(string senha)
        {
            AlteracaoLogin verir = new AlteracaoLogin();
            verir.verificaçao(senha);


        }

    }

        }
    

