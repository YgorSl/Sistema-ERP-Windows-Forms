using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RestauranteADM.BASE.BaterPonto
{
    public class BaterPontoDatabase
    {

        public string id, nome;


        public void Consultar(string cpf)
        {

            string script = @"select *from tb_funcionarios where ds_cpf=@ds_cpf";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_cpf", cpf));



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);


            if (reader.Read() == true)
            {


                nome = reader["nm_nome"].ToString();
                id = reader["id_funcionarios"].ToString();


                MessageBox.Show("olá " + nome + " seja bem vindo");

                reader.Close();
            }
            else
            {
                MessageBox.Show("seu cpf estar errado");
                

            }
        }

        public int Salvar(BaterPontoDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_ponto10` (id_funcionario, dt_data,hr_entrada,hr_almoço_ida,hr_almoço_volta,hr_saida) VALUES (@id_funcionario,@dt_data,@hr_entrada,@hr_almoço_ida,@hr_almoço_volta,@hr_saida)";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("id_funcionario", dto.IdFuncionario));
            parms.Add(new MySqlParameter("dt_data", dto.Data));
            parms.Add(new MySqlParameter("hr_entrada", dto.Entrada));
            parms.Add(new MySqlParameter("hr_almoço_ida", dto.IdaAlmoço));
            parms.Add(new MySqlParameter("hr_almoço_volta", dto.VoltaAlmoço));
            parms.Add(new MySqlParameter("hr_saida", dto.Saida));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }






        public void Update(BaterPontoDTO dto)
        {
            string script = @" UPDATE `mydb`.`tb_ponto10` SET hr_almoço_ida = @hr_almoço_ida WHERE id_ponto = @id_ponto; ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_ponto", dto.Id));
            parms.Add(new MySqlParameter("hr_almoço_ida", dto.IdaAlmoço));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Update2(BaterPontoDTO dto)
        {
            string script = @" UPDATE `mydb`.`tb_ponto10` SET hr_almoço_volta = @hr_almoço_volta WHERE id_ponto = @id_ponto; ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_ponto", dto.Id));
            parms.Add(new MySqlParameter("hr_almoço_volta", dto.VoltaAlmoço));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Update3(BaterPontoDTO dto)
        {
            string script = @" UPDATE `mydb`.`tb_ponto10` SET hr_saida = @hr_saida WHERE id_ponto = @id_ponto; ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_ponto", dto.Id));
            parms.Add(new MySqlParameter("hr_saida", dto.VoltaAlmoço));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }













        public BaterPontoDTO atualizar()
        {

            string script = @"select max(id_ponto) as id_ponto from tb_ponto10";



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            BaterPontoDTO dt = null;

            if (reader.Read() == true)
            {

                dt = new BaterPontoDTO();
                dt.Id = reader.GetInt32("id_ponto");


            }
            reader.Close();
            return dt;
        }



        public BaterpontoConfirmaçao listar(int id,DateTime data)
        {

            string script = @"select *from tb_ponto10 where dt_data=@data and id_funcionario=@idfuncio";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("data", data ));
            parms.Add(new MySqlParameter("idfuncio", id ));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            BaterpontoConfirmaçao lista = new BaterpontoConfirmaçao();
            while (reader.Read())
            {
                BaterpontoConfirmaçao dto = new BaterpontoConfirmaçao();
                dto.Id = reader.GetInt32("id_cardapio");
                dto.Data = reader.GetDateTime("dt_data");
                dto.Entrada = reader.GetDateTime("hr_entrada");
                dto.IdaAlmoço = reader.GetDateTime("hr_almoço_ida");
                dto.VoltaAlmoço = reader.GetDateTime("hr_almoço_volta");
                dto.Saida = reader.GetDateTime("hr_saida");

           
            }
            reader.Close();

            return lista;

        }

      









    }

}