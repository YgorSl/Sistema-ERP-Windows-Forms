using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.FluxoDeCaixa
{
    public class FluxodecaixaDatabase
    {

        public List<FluxodecaixaDTO> Filtro(DateTime start, DateTime end)
        {

            string script = @"select *from Fluxo_view where data >= @start and data <= @end";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("start", start));
            parms.Add(new MySqlParameter("end", end));




            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FluxodecaixaDTO> lista = new List<FluxodecaixaDTO>();
            while (reader.Read() == true)
            {
                FluxodecaixaDTO vw = new FluxodecaixaDTO();
                vw.valorareceber = reader.GetDecimal("nm_prato");
                vw.valorpagar = reader.GetDecimal("data_venda");
            
                lista.Add(vw);
            }
            return lista;
        }
    }
}
