using MySql.Data.MySqlClient;
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
        public List<FolhaPagamentoDTO> Consultar(string folha)
        {
            FolhaPagamentoDatabase db = new FolhaPagamentoDatabase();
            return db.Consultar(folha);
        }

        public List<FolhaPagamentoDTO> Listar()
        {
            FolhaPagamentoDatabase db = new FolhaPagamentoDatabase();
            return db.Listar();
        }

    }
}




