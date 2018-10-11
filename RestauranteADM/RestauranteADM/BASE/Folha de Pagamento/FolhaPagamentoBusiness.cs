using MySql.Data.MySqlClient;
using RestauranteADM.BASE.Cardapio;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Folha_de_Pagamento
{
    public class FolhaPagamentoBusiness
    {

        public void salvar(FolhaPagamentoDTO i)
        {
            FolhaPagamentoDatabase bd = new FolhaPagamentoDatabase();
            bd.Salva(i);
        }
        public List<FolhaPagamentoDTO> Consultar(string nome,string cpf)
        {
            FolhaPagamentoDatabase db = new FolhaPagamentoDatabase();
            return db.Consultar(nome,cpf);
        }

        public  void Remover(int id)
        {
            FolhaPagamentoDatabase db = new FolhaPagamentoDatabase();
             db.Remover(id);
        }

       


    }
}




