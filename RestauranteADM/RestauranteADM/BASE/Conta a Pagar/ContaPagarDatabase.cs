using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Conta_a_Pagar
{
   public class ContaPagarDatabase
    {
      

        public int Salvar(ContaPagarDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_conta_pagar` ( vl_preço, dt_data,tipo, dt_validade) VALUES (@vl_preço,@dt_data,@tipo,@dt_validade)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("vl_preço", dto.Preço));
            parms.Add(new MySqlParameter("dt_data", dto.chegou));
            parms.Add(new MySqlParameter("tipo", dto.tipo));
            parms.Add(new MySqlParameter("dt_validade", dto.validade));





            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;


        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_conta_pagar WHERE id_conta_pagar = @id_conta_pagar ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_conta_pagar ", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<ContaPagarDTO> Filtro(DateTime start, DateTime end)
        {


            string script = @"select* from tb_conta_pagar where dt_data>= @start and dt_validade <= @end";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("start", start));
            parms.Add(new MySqlParameter("end", end));



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ContaPagarDTO> lista = new List<ContaPagarDTO>();
            while (reader.Read())
            {
                ContaPagarDTO dto = new ContaPagarDTO();
                dto.Id = reader.GetInt32("id_conta_pagar");
                dto.chegou = reader.GetDateTime("dt_data");
                dto.tipo = reader.GetString("tipo");
                dto.validade = reader.GetDateTime("dt_validade");
                dto.Preço = reader.GetDouble("vl_preço");


                lista.Add(dto);
            }
            reader.Close();

            return lista;

        }
    }
}

