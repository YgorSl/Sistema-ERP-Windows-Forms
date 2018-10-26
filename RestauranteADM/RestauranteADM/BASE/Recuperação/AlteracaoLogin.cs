using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using RestauranteADM.TELAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM.BASE.Recuperação
{
   public class AlteracaoLogin
    {
       

            private string Gmail, Nome,senharecu;
            private string mensagem;

            private int numeroaleatorio;
       public string s;


        public string recuperaçaosenhar(string Recuperacao)
            {

                string script = @"select *from Recuperaçao_Login where Recupecao=@Recupecao";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("Recupecao", Recuperacao));



                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(script, parms);


                if (reader.Read() == true)
                {

               

          

                    Gmail = reader["Gmail"].ToString();
                    Nome = reader["Nome"].ToString();
                    senharecu = reader["Recupecao"].ToString();
                    enviaremailalteraçao();
                    mensagem = "olá " + Nome + "  enviamos para seu Gmail " + Gmail + " o codigo de alteraçao de login e senhar ";
                Codigo(senharecu, s);
                reader.Close();
                }
                else
                {
                    mensagem = "seu usuario nao existe";
                }
                return mensagem;
            }

       


            public void enviaremailalteraçao()
            {

            Random aleatorio = new Random();
            numeroaleatorio = aleatorio.Next();
           s = numeroaleatorio.ToString();



            MailMessage gmail = new MailMessage();


                gmail.From = new MailAddress("seitadoscarecas@gmail.com");
                gmail.To.Add(Gmail);
                gmail.Subject = "recuperaçao de login";
                gmail.Body = " olá  " + Nome + " seu codigo de alteraçao e " + s;
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
                catch (Exception ex)
                {
                    gmail.Dispose();
                }
            }


        public void Codigo(string Recuperacao,string codigo)
        {

            string script = @"UPDATE Recuperaçao_Login Senha=@ds_senha where Recupecao=@Recupecao";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("Recupecao", Recuperacao));
            parms.Add(new MySqlParameter("Senha", codigo));
        



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);




        }





        }
    }
