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


        private string Gmail, Nome, Login, senha;
        private string mensagem;

        public string recuperaçaosenhar(string Recuperacao)
        {

            string script = @"select *from Recuperaçao_Login where Recupecao=@Recupecao";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Recupecao", Recuperacao ));



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);


            if (reader.Read() == true)
            {

                Gmail = reader["Gmail"].ToString();
                Nome = reader["Nome"].ToString();
                senha = reader["Senha"].ToString();
                Login = reader["Login"].ToString();
                enviaremail();
                mensagem = "olá " + Nome + "  enviamos para seu Gmail " +  Gmail +  " a recuperaçao de login e senhar ";
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
            
            MailMessage gmail = new MailMessage();


            gmail.From = new MailAddress("seitadoscarecas@gmail.com");
            gmail.To.Add(Gmail);
            gmail.Subject = "recuperaçao de login";
            gmail.Body = " olá querido " + Nome +  " seu usuario de login é " + Login+  " e sua senha é " +  senha;
            gmail.Priority = MailPriority.Normal;

            SmtpClient smpt = new SmtpClient();
            smpt.Host = "smtp.gmail.com";
            smpt.Port = 587;
            smpt.EnableSsl = true;
            smpt.Credentials = new NetworkCredential("seitadoscarecas@gmail.com", "brunoemarcos");

            try
            {
                smpt.Send(gmail);
            }
            catch(Exception ex)
            {
                gmail.Dispose();
            }
            
        }







    }
}

    
