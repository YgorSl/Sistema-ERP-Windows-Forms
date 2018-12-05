using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.teste
{
    public class TesteDatabase
    {

        public void Update(int Id)
        {
            string script = @"UPDATE `tb_biblioteca`.`tb_livro` SET `ds_estaemuso` =1 WHERE id_livro=@id_livro";




            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_livro", Id));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);





            ///UPDATE `tb_biblioteca`.`tb_livro` SET `ds_estaemuso` = '0' WHERE(`id_livro` = '1');
            ///UPDATE `tb_biblioteca`.`tb_livro` SET `ds_estaemuso` = '0' WHERE(`id_livro` = '2');
            ///UPDATE `tb_biblioteca`.`tb_livro` SET `ds_estaemuso` = '0' WHERE(`id_livro` = '3');



        }
        public int Salvar(TesteDTO dto)
        {
            string script = @"INSERT INTO `tb_biblioteca`.`tb_emprestimo` (id_aluno, dt_emprestimo, dt_vencimento) VALUES (@id_aluno,@dt_emprestimo,@dt_vencimento)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_aluno", dto.Id_aluno));
            parms.Add(new MySqlParameter("dt_emprestimo", dto.emprestimo));
            parms.Add(new MySqlParameter("dt_vencimento", dto.vencimento));



            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
    }
}
