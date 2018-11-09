using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using RestauranteADM.TELAS;
using RestauranteADM.TELAS.Cadastro;
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

    
        private string Gmail, Nome,id,idt;
            private string mensagem;

            private int numeroaleatorio,ift;
            public string s;


        public string aleatorio()
        {
            Random aleatorio = new Random();
            numeroaleatorio = aleatorio.Next();
            s = numeroaleatorio.ToString();
            return s;
        }

        public string recuperaçaosenhar(string Recuperacao)
            {

                string script = @"select *from Recuperaçao where Recupecao=@Recupecao";

                List<MySqlParameter> parms = new List<MySqlParameter>();
                parms.Add(new MySqlParameter("Recupecao", Recuperacao));



                Database db = new Database();
                MySqlDataReader reader = db.ExecuteSelectScript(script, parms);


                if (reader.Read() == true)
                {

                string s = aleatorio();




                   Gmail = reader["Gmail"].ToString();
                    Nome = reader["Nome"].ToString();
                    id = reader["idfuncio"].ToString();
                    enviaremailalteraçao();
                    Codigo(id,s);
                    mensagem = "olá " + Nome + "  enviamos para seu Gmail " + Gmail + " o codigo de alteraçao de login e senhar "+s;

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



            string s = aleatorio();


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


        public void Codigo(string id,string codigo)
        {

            string script = @"UPDATE Recuperaçao set Senha=@ds_senha where idfuncio=@idfuncio";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("idfuncio", id));
            parms.Add(new MySqlParameter("ds_senha", codigo));
        


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);




        }

        public void verificaçao( string codigo)
        {

            string script = @"select * from Recuperaçao where Senha=@ds_senha ";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("ds_senha", codigo));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            if(reader.Read() ==true)
            {
                idt = reader["idfuncio"].ToString();

                alteraçaodesenha oi = new alteraçaodesenha();
                oi.Show();
                oi.LoadScreen(idt);




            }
            else
            {
                splash oi = new splash();
                oi.Show();
      


            }




        }

        public void mundançadesenha(int id,string login,string senha)
        {

            string script = @"UPDATE Recuperaçao set Senha=@ds_senha ,Login=@nm_login where idfuncio=@idfuncio";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("idfuncio", id));
            parms.Add(new MySqlParameter("ds_senha", senha));
            parms.Add(new MySqlParameter("nm_login", login));



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);



        }




    }
    }
