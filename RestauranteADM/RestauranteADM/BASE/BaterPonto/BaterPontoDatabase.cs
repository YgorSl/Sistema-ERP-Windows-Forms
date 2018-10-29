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
                bater_ponto oi = new bater_ponto();
                oi.LoadScreen(id);
             
                MessageBox.Show( "olá " + nome + " seja bem vindo");

                reader.Close();
            }
            else
            {
                MessageBox.Show("seu cpf estar errado");


            }
       }

              public int Salvar(BaterPontoDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_ponto` (id_funcionario, dt_data, hr_entrada, hr_almoço_ida, hr_almoço_volta, hr_saida) 
                                                        VALUES ( @id_funcionario, @dt_data, @hr_entrada, @hr_almoço_ida, @hr_almoço_volta, @hr_saida);";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            
        

            id = dto.IdFuncionario.ToString();

        

        parms.Add(new MySqlParameter("id_funcionario", id));
            parms.Add(new MySqlParameter("dt_data", dto.Data));
            parms.Add(new MySqlParameter("hr_entrada", dto.Entrada));
            parms.Add(new MySqlParameter(" hr_almoço_ida", dto.IdaAlmoço));
            parms.Add(new MySqlParameter("hr_almoço_volta", dto.VoltaAlmoço));
            parms.Add(new MySqlParameter("hr_saida", dto.Saida));

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }

    }
    
}
