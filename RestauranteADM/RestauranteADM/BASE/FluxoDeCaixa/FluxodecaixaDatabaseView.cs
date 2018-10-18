using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.FluxoDeCaixa
{
    public class FluxodecaixaDatabaseView
    {

        public List<FluxodecaixaView> Filtro(DateTime start, DateTime end)
        {

            string script = @"select* from Fluxo_view where dt_data>= @start and @end <= dt_data";


 

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("start", start));
            parms.Add(new MySqlParameter("end", end));

         


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FluxodecaixaView> lista = new List<FluxodecaixaView>();
            while (reader.Read() == true)
            {
                FluxodecaixaView vw = new FluxodecaixaView();
                vw.data = reader.GetDateTime("dt_data");
                vw.valortotal = reader.GetDecimal("vl_valor");
                vw.tipo_de_operacao = reader.GetString("ds_caixa");
                vw.movimento = reader.GetString("ds_movimento");


                lista.Add(vw);
            }
            return lista;
        }
    }
}
