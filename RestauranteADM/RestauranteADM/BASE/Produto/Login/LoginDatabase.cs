
using MySql.Data.MySqlClient;
using RestauranteADM.BASE.Funcionario;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Login
{
    public class LoginDatabase
    {
        public LoginDTO Login(string login, string senha)
        {
            string script = @" select * "+
                            "    from tb_permissao   " +
                            " inner join tb_funcionarios  " +
                            "  on tb_permissao.id_funcionario = tb_funcionarios.id_funcionarios " +
                           "    where nm_login = @login   " +
                            "    and ds_senha =  @senha     ";



            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("login", login));
            parms.Add(new MySqlParameter("senha", senha));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            LoginDTO acess = null;
            if (reader.Read() == true)
            {
                acess = new LoginDTO();
                acess.Id = reader.GetInt32("id_permissao");
                acess.permissaototal = reader.GetBoolean("perm_total");
                acess.permissaoRH = reader.GetBoolean("perm_rh");
                acess.permissaofinanceiro = reader.GetBoolean("perm_financeiro");
                acess.permissaovendas = reader.GetBoolean("perm_vendas");
                acess.permissaocompras = reader.GetBoolean("perm_compras");
                acess.permissaocadastro = reader.GetBoolean("perm_cadastro");


                acess.funcio = new FuncionarioDTO();
                acess.funcio.Nome = "nm_nome";
                acess.funcio.Cpf = "ds_cpf";
       


            }
            return acess;




        }

       
    }
    }
