using MySql.Data.MySqlClient;
using RestauranteADM.BASE.Funcionario;
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

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_folha_de_pagamento WHERE id_folha_pagamento = @id_folha_pagamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folha_pagamento", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<FolhaPagamentoDTO> Consultar(string nome,string cpf)
        {
            string script = @"select * from tb_funcionarios" +
                              " inner join tb_folha_de_pagamento" +
                               "  on tb_folha_de_pagamento.id_funcionario=tb_funcionarios.id_funcionarios";
                             



         
        
            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<FolhaPagamentoDTO> lista = new List<FolhaPagamentoDTO>();
            while (reader.Read())
            {
                FolhaPagamentoDTO dto = new FolhaPagamentoDTO();
                dto.Id = reader.GetInt32("id_folha_pagamento");
                dto.IdFuncionario = reader.GetInt32("id_funcionario");
                dto.VR = reader.GetDouble("vl_VR");
                dto.DSR = reader.GetDouble("vl_DSR");
                dto.SalarioLiquido = reader.GetDouble("vl_SalarioLiquido");
                dto.HE = reader.GetDouble("ds_He");
                dto.VT = reader.GetDouble("ds_VT");
                dto.INSS = reader.GetDouble("ds_INSS");
                dto.IRRF = reader.GetDouble("ds_IRRF");
                dto.FGTS = reader.GetDouble("ds_FGTS");
                dto.Convenio = reader.GetDouble("ds_convenio");
                dto.CestaBasica = reader.GetDouble("ds_cestabasica");
                dto.Atraso = reader.GetDouble("desco_atraso");
                dto.Falta = reader.GetDouble("ds_faltas");
                dto.Bonus = reader.GetDouble("ds_bonus");



                dto.funcio = new FuncionarioDTO();
                dto.funcio.fpama = new FolhaPagamentoDTO();
                dto.funcio.fpama.Id = dto.Id;
                dto.funcio.Nome = reader.GetString("nm_nome");
                dto.funcio.Cpf = reader.GetString("ds_cpf");
                dto.funcio.Rg = reader.GetString("ds_RG");
                dto.funcio.Endereço = reader.GetString("ds_endereco");
                dto.funcio. Salario = reader.GetDouble("ds_Salario");



                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }

       
    }
}