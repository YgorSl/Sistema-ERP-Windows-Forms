using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class ComprasViewDatabase
    {
        public List<ComprasView> Filtro(DateTime start, DateTime end)
        {

            string script = @"select *from compravw where dt_compra>= @start and dt_compra <= @end";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("start", start));
            parms.Add(new MySqlParameter("end", end));




            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ComprasView> lista = new List<ComprasView>();
            while (reader.Read() == true)
            {
                ComprasView vw = new ComprasView();
                vw.Nome = reader.GetString("nm_nome");
                vw.Data = reader.GetDateTime("dt_compra");
                vw.Qtd = reader.GetInt32("vl_qtd");
                vw.Total = reader.GetInt32("vl_total");

                lista.Add(vw);
            }
            return lista;
        }
    }
}
