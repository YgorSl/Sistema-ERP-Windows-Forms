using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.vendas
{
    public class VendasViewDatabase
    {

        public List<VendasViewDto> Filtro(DateTime start, DateTime end)
        {

            string script = @"select *from teste where data_venda >= @start and data_venda <= @end";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("start", start));
            parms.Add(new MySqlParameter("end", end));




            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VendasViewDto> lista = new List<VendasViewDto>();
            while (reader.Read() == true)
            {
                VendasViewDto vw = new VendasViewDto();
                vw.Data = reader.GetDateTime("data_venda");
                vw.Total = reader.GetInt32("vl_final");
                vw.Nome_cliente = reader.GetString("nm_nome");

                lista.Add(vw);
            }
            return lista;
        }






    }
}
