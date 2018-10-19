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
      
        private string mensagem;
        private SqlCommand comando = new SqlCommand();


      public string recuperaçaosenhar(string Recuperacao)
        {

            string script = @"select *from Recuperaçao_Login where Recupecao=@Recupecao";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Recupecao", "%" + Recuperacao + "%"));



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<RecuperaçaoDTO> lista = new List<RecuperaçaoDTO>();
            if (reader.Read()==true)
            {
                RecuperaçaoDTO dto = new RecuperaçaoDTO();
                dto.email = reader["Gmail"].ToString();
                dto.nome = reader["Nome"].ToString();
                dto.senha = reader["Senha"].ToString();
                dto.login = reader["Login"].ToString();
                enviaremail();
                mensagem = "olá " + dto.nome + "enviado para seu email" + dto.email + "a recuperaçao de login e senhar ";
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
            string origem = "raimundo908908@gmail.com";
            string Senha = "saopaulo10";

            RecuperaçaoDTO dto = new RecuperaçaoDTO();
            MailMessage gmail = new MailMessage();


            gmail.From = new MailAddress("raimundo908908@gmail.com");
            gmail.To.Add(dto.email);
            gmail.Subject = "recuperaçao de login";
            gmail.Body = "olá querido" + dto.nome + "seu usuario de login é" + dto.login + "e sua senha é" + dto.senha;
            gmail.Priority = MailPriority.Normal;

            SmtpClient smpt = new SmtpClient();
            smpt.Host = "smtp.gmail.com";
            smpt.Port = 587;
            smpt.EnableSsl = true;
            smpt.UseDefaultCredentials = false;
            smpt.Credentials = new NetworkCredential(origem, Senha);
            smpt.EnableSsl = true;
            smpt.Send(gmail);
        }







    }
}
