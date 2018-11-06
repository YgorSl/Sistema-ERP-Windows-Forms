using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.CP_Pagar
{
    public class CP_Database
    {
        public int Salvar(CP_DTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_conta_pagar` ( ds_prestador, ds_documento, ds_operacao, ds_conta, ds_agencia, nm_banco,  ds_prazo, vl_valor, dt_data, dt_vencimento, ds_ok) VALUES (@ds_prestador, @ds_documento, @ds_operacao, @ds_conta, @ds_agencia, @nm_banco,  @ds_prazo, @vl_valor, @dt_data, @dt_vencimento, @ds_ok)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("vl_valor", dto.Valor));
            parms.Add(new MySqlParameter("dt_data", dto.chegou));
            parms.Add(new MySqlParameter("ds_prestador", dto.Prestador));
            parms.Add(new MySqlParameter("dt_vencimento", dto.vencimento));
            parms.Add(new MySqlParameter("ds_documento", dto.Documento));
            parms.Add(new MySqlParameter("ds_operacao", dto.Operacao));
            parms.Add(new MySqlParameter("ds_agencia", dto.Agencia));
            parms.Add(new MySqlParameter("ds_conta", dto.Conta));
            parms.Add(new MySqlParameter("nm_banco", dto.Banco));
            parms.Add(new MySqlParameter("ds_ok", dto.ok));


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


        public List<CP_DTO> Filtro(DateTime start, DateTime end)
        {


            string script = @"select* from tb_conta_pagar where dt_data>= @start and dt_validade <= @end";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("start", start));
            parms.Add(new MySqlParameter("end", end));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CP_DTO> lista = new List<CP_DTO>();
            while (reader.Read())
            {
                CP_DTO dto = new CP_DTO();
                dto.Id = reader.GetInt32("id_conta_pagar");
                dto.Valor = reader.GetDouble("vl_valor");
                dto.chegou = reader.GetDateTime("dt_data");
                dto.Prestador = reader.GetString("ds_prestador");
                dto.vencimento = reader.GetDateTime("dt_vencimento");
                dto.Documento = reader.GetString("ds_documento");
                dto.Operacao = reader.GetString("ds_operacao");
                dto.Agencia = reader.GetInt32("ds_agencia");
                dto.Conta = reader.GetInt32("ds_conta");
                dto.Banco = reader.GetString("nm_banco");
                dto.ok = reader.GetBoolean("ds_ok");

                lista.Add(dto);
            }
            reader.Close();

            return lista;

        }
        public List<CP_DTO> Consultar(double Valor, DateTime chegou, string Prestador, DateTime vencimento, string documento, string operacao, int agencia, int conta, string banco, bool ok)
        {


            string script = @"select *from tb_conta_pagar where nm_nome like @nome and ds_cpf like @cpf";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("vl_valor", "%" + Valor + "%"));
            parms.Add(new MySqlParameter("dt_data", "%" + chegou + "%"));
            parms.Add(new MySqlParameter("ds_prestador", "%" + Prestador + "%"));
            parms.Add(new MySqlParameter("dt_vencimento", "%" + vencimento + "%"));
            parms.Add(new MySqlParameter("ds_documento", "%" + documento + "%"));
            parms.Add(new MySqlParameter("ds_operacao", "%" + operacao + "%"));
            parms.Add(new MySqlParameter("ds_agencia", "%" + agencia + "%"));
            parms.Add(new MySqlParameter("ds_conta", "%" + conta + "%"));
            parms.Add(new MySqlParameter("nm_banco", "%" + banco + "%"));
            parms.Add(new MySqlParameter("ds_ok", "%" + ok + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

        }
    }
}
