using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Fluxo_de_Caixa
{
    public class FluxoCaixaDatabase
    {



        public int Salvar(FluxoCaixaDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_fluxo_de_caixa`(vl_ganhar, vl_perdeu, vl_saldo,dt_periodo_comeco,dt_ultimo)
                                                                      VALUES(@vl_ganhar,@vl_perdeu,@vl_saldo,@dt_periodo_comeco,@dt_ultimo)";









            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("vl_ganhar", dto.ganhor));
            parms.Add(new MySqlParameter("vl_perdeu", dto.perdar));
            parms.Add(new MySqlParameter("vl_saldo", dto.saldo));
            parms.Add(new MySqlParameter("dt_periodo_comeco", dto.Perido_inicial));
            parms.Add(new MySqlParameter("dt_ultimo", dto.Perido_final));
      
     


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public List<FluxoCaixaDTO> Filtro(DateTime start, DateTime end)
        {

            string script = @"select* from tb_fluxo_de_caixa where dt_periodo_inicio>= @start and @end <= dt_periodo_final";




            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("start", start));
            parms.Add(new MySqlParameter("end", end));




            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FluxoCaixaDTO> lista = new List<FluxoCaixaDTO>();
            while (reader.Read() == true)
            {
                FluxoCaixaDTO vw = new FluxoCaixaDTO();
                vw.ganhor = reader.GetDouble("vl_ganhar");
                vw.perdar = reader.GetDouble("vl_valor");
                vw.saldo = reader.GetFloat("vl_saldo");
                vw.Perido_inicial = reader.GetDateTime("dt_periodo_comeco");
                vw.Perido_final = reader.GetDateTime("dt_ultimo");

                lista.Add(vw);
            }
            return lista;
        }
    }
}

