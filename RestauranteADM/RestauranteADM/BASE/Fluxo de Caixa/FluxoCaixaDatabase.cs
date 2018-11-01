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
            string script = @" INSERT INTO `mydb`.`tb_fluxo_de_caixa` ( vl_ganhar, vl_perdeu, vl_saldo, dt_periodo_inicio, dt_periodo_final) 
                                                               VALUES ( @vl_ganhar, @vl_perdeu, @vl_saldo, @dt_periodo_inicio, @dt_periodo_final);";






            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("vl_ganhar", dto.ganhor));
            parms.Add(new MySqlParameter("vl_perdeu", dto.perdar));
            parms.Add(new MySqlParameter("vl_saldo", dto.saldo));
            parms.Add(new MySqlParameter("dt_periodo_inicio", dto.Perido_inicial));
            parms.Add(new MySqlParameter("dt_periodo_final", dto.Perido_final));
      
     


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
    }
}
