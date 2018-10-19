using MySql.Data.MySqlClient;
using RestauranteADM.BASE.Cliente;
using RestauranteADM.BASE.Usuario;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace RestauranteADM.BASE
{
    public class Senhar
    {
       
        private string email, nome, senha,login;
        private string mensagem;
        private SqlCommand comando = new SqlCommand();


      public string recuperaçaosenhar(string cpf)
        {

            string script = @"select *from tb_funcionarios  nm_cpf=@cpf ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("cpf", "%" + cpf + "%"));



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            if (reader.Read()==true)
            {
                email = reader["ds_email"].ToString();
                nome = reader["ds_nome"].ToString();
                senha = reader["ds_senha"].ToString();
                enviaremail();
                senha = reader["ds_login"].ToString();
                mensagem = "olá " + nome + "enviado para seu email" + email + "a recuperaçao de login e senhar ";
                reader.Close();
            }
            else
            {
                mensagem = "seu usuario nao existe";
            }
            return mensagem;
             }
        public void enviaremail()
        {
            string origem = "seitadoscarecas@gmail.com";
            string senha = "brunoemarcos";

            MailMessage gmail = new MailMessage();


            gmail.From = new MailAddress("seitadoscarecas@gmail.com");
            gmail.To.Add(email);
            gmail.Subject = "recuperaçao de login";
            gmail.Body = "olá querido" + nome + "seu usuario de login é" + login + "e sua senha é" + senha;
            gmail.Priority = MailPriority.Normal;

            SmtpClient smpt = new SmtpClient();
            smpt.Host = "smtp.gmail.com";
            smpt.Port = 587;
            smpt.EnableSsl = true;
            smpt.UseDefaultCredentials = false;
            smpt.Credentials = new NetworkCredential(origem, senha);
            smpt.EnableSsl = true;
            smpt.Send(gmail);
        }







    }
}
