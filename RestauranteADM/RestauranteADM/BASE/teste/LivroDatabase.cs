using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.teste
{
    public class LivroDatabase
    {
        public int Salvar(LivroDTO dto)
        {
            string script = @"INSERT INTO `tb_biblioteca`.`tb_livro` (id_categoria,nm_livro,nm_editora,nm_autor,dt_publicacao,ds_codigolivro) VALUES (@id_categoria,@nm_livro,@nm_editora,@nm_autor,@dt_publicacao,@ds_codigolivro)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_livro", dto.nome));
            parms.Add(new MySqlParameter("nm_autor", dto.autor));
            parms.Add(new MySqlParameter("nm_editora", dto.editora));
            parms.Add(new MySqlParameter("dt_publicacao", dto.lançamento));
            parms.Add(new MySqlParameter("id_categoria", dto.Categoria));
            parms.Add(new MySqlParameter("ds_codigolivro", dto.codigo));
            

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
    }
}
