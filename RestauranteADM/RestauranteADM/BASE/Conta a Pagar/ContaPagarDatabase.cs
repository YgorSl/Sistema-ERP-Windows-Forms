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
            string script = @"INSERT INTO `mydb`.`tb_conta_paga1` (ds_tipo_cobrança,nm_conta_contabil,ds_conta_contabil,ds_agencia,ds_banco,ds_conta,ds_observaçao,dt_emissao,dt_data,dt_vencimento,vl_preço,ds_parcelados,nm_prestador,ds_cnpj)
                                                         VALUES   (@ds_tipo_cobrança,@nm_conta_contabil,@ds_conta_contabil,@ds_agencia,@ds_banco,@ds_conta,@ds_observaçao,@dt_emissao,@dt_data,@dt_vencimento,@vl_preço,@ds_parcelados,@nm_prestador,@ds_cnpj)";






            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_tipo_cobrança", dto.tipo_cobrança));
            parms.Add(new MySqlParameter("nm_conta_contabil", dto.conta_contabil));
            parms.Add(new MySqlParameter("ds_conta_contabil", dto.conta_contabil_ds));
            parms.Add(new MySqlParameter("ds_agencia", dto.agencia));
            parms.Add(new MySqlParameter("ds_banco", dto.banco));
            parms.Add(new MySqlParameter("ds_conta", dto.conta));
            parms.Add(new MySqlParameter("ds_observaçao", dto.observaçao));
            parms.Add(new MySqlParameter("dt_emissao", dto.emissao));
            parms.Add(new MySqlParameter("dt_data", dto.data_cadastro));
            parms.Add(new MySqlParameter("dt_vencimento", dto.vencimento));
            parms.Add(new MySqlParameter("vl_preço", dto.valor_titulo));
            parms.Add(new MySqlParameter("ds_parcelados", dto.parcelados));
            parms.Add(new MySqlParameter("nm_prestador", dto.Prestador));
            parms.Add(new MySqlParameter("ds_cnpj", dto.Cnpj));



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
                ///

               /// lista.Add(dto);
            }
            reader.Close();

            return lista;

        }

        public void Update(ContaPagarDTO dto)
        {
            string script = @"UPDATE `mydb`.`tb_conta_pagar` SET pg_pagou = 1 WHERE id_conta_pagar=@id_conta_pagar";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_conta_pagar", dto.Id));





            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
         


        }
    }
}

