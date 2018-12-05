using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.teste
{
    public class Livrobusiness
    {
        public void Salvar(LivroDTO dro)
        {
            LivroDatabase database = new LivroDatabase();
            database.Salvar(dro);


        }
        public List<LivroDTO> Lista()
        {


            string script = @"SELECT * FROM tb_livro";



            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, null);

            List<LivroDTO> lista = new List<LivroDTO>();
            while (reader.Read())
            {

                LivroDTO dto = new LivroDTO();
                dto.Id = reader.GetInt32("id_livro");
                dto.nome = reader.GetString("nm_livro");

                lista.Add(dto);
            }


            return lista;


        }
    }
}

