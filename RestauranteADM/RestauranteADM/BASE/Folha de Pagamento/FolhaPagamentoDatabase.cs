using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Folha_de_Pagamento
{
    public class FolhaPagamentoDatabase
    {

        public int Salva(FolhaPagamentoDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_folha_de_pagamento` (id_funcionario, vl_VR, vl_DSR, vl_SalarioLiquido, ds_He, ds_VT, ds_INSS, ds_IRRF, ds_FGTS, ds_convenio, ds_cestabasica, desco_atraso, ds_faltas, ds_bonus) 
                                                                  VALUES (@id_funcionario,@vl_VR,@vl_DSR,@vl_SalarioLiquido,@ds_He,@ds_VT,@ds_INSS,@ds_IRRF,@ds_FGTS,@ds_convenio,@ds_cestabasica,@desco_atraso,@ds_faltas,@ds_bonus);";





            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", dto.IdFuncionario));
            parms.Add(new MySqlParameter("vl_VR", dto.VR));
            parms.Add(new MySqlParameter("vl_DSR", dto.DSR));
            parms.Add(new MySqlParameter("vl_SalarioLiquido", dto.SalarioLiquido));
            parms.Add(new MySqlParameter("ds_He", dto.HE));
            parms.Add(new MySqlParameter("ds_VT", dto.VT));

            parms.Add(new MySqlParameter("ds_INSS", dto.INSS));
            parms.Add(new MySqlParameter("ds_IRRF", dto.IRRF));
            parms.Add(new MySqlParameter("ds_FGTS", dto.FGTS));
            parms.Add(new MySqlParameter("ds_convenio", dto.Convenio));
            parms.Add(new MySqlParameter("ds_cestabasica", dto.CestaBasica));
            parms.Add(new MySqlParameter("desco_atraso", dto.Atraso));
            parms.Add(new MySqlParameter("ds_faltas", dto.Falta));

            parms.Add(new MySqlParameter("ds_bonus", dto.Bonus));



            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

        public List<FolhaPagamentoDTO> Consultar(string folha)
        {
            string script = @"SELECT * FROM tb_funcionarios WHERE nm_nome like @nm_Nome";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", folha + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FolhaPagamentoDTO> lista = new List<FolhaPagamentoDTO>();
            while (reader.Read())
            {
                FolhaPagamentoDTO dto = new FolhaPagamentoDTO();
                dto.Id = reader.GetInt32("id_folha_pagamento");
                dto.IdFuncionario = reader.GetInt32("id_funcionario");
                dto.HE = reader.GetDouble("ds_He");
                dto.DSR = reader.GetDouble("vl_DSR");
                dto.VR = reader.GetDouble("vl_VR");
                dto.VT = reader.GetDouble("ds_VT");
                dto.SalarioFamilia = reader.GetDouble("vl_SF");
                dto.Bonus = reader.GetDouble("ds_bonus");
                dto.Convenio = reader.GetDouble("ds_convenio");
                dto.Atraso = reader.GetDouble("desco_atraso");
                dto.Falta = reader.GetDouble("ds_faltas");
                dto.CestaBasica = reader.GetDouble("ds_cestabasica");
                dto.INSS = reader.GetDouble("ds_INSS");
                dto.IRRF = reader.GetDouble("ds_IRRF");
                dto.FGTS = reader.GetDouble("ds_FGTS");
                dto.SalarioLiquido = reader.GetDouble("vl_SalarioLiquido");
                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }

        public List<FolhaPagamentoDTO> Listar()
        {
            string script = @"SELECT * FROM tb_funcionarios";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FolhaPagamentoDTO> lista = new List<FolhaPagamentoDTO>();
            while (reader.Read())
            {
                FolhaPagamentoDTO dto = new FolhaPagamentoDTO();
                dto.Id = reader.GetInt32("id_folha_pagamento");
                dto.IdFuncionario = reader.GetInt32("id_funcionario");
                dto.HE = reader.GetDouble("ds_He");
                dto.DSR = reader.GetDouble("vl_DSR");
                dto.VR = reader.GetDouble("vl_VR");
                dto.VT = reader.GetDouble("ds_VT");
                dto.SalarioFamilia = reader.GetDouble("vl_SF");
                dto.Bonus = reader.GetDouble("ds_bonus");
                dto.Convenio = reader.GetDouble("ds_convenio");
                dto.Atraso = reader.GetDouble("desco_atraso");
                dto.Falta = reader.GetDouble("ds_faltas");
                dto.CestaBasica = reader.GetDouble("ds_cestabasica");
                dto.INSS = reader.GetDouble("ds_INSS");
                dto.IRRF = reader.GetDouble("ds_IRRF");
                dto.FGTS = reader.GetDouble("ds_FGTS");
                dto.SalarioLiquido = reader.GetDouble("vl_SalarioLiquido");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}