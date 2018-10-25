using MySql.Data.MySqlClient;
using RestauranteADM.BASE.Fornecedor;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class CompraDatabase
    {
        public int Salvar(CompraDTO dto)
        {
            string script = @"INSERT INTO `tb_compra` (id_fornecedor, dt_compra) 
                            VALUES (@id_fornecedor, @dt_compra)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", dto.Forneceddor.Id));
            parms.Add(new MySqlParameter("dt_compra", dto.Data));


            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }
        public List<CompraDTO> filtro(DateTime start, DateTime end)
        {
            string script = @"select *from tb_compra where dt_compra >= @start and  dt_compra<=@end ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("start", start));
            parms.Add(new MySqlParameter("end", end));




            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CompraDTO> lista = new List<CompraDTO>();
            while (reader.Read() == true)
            {
                CompraDTO comp = new CompraDTO();
                comp.Id = reader.GetInt32("id_compra");
                comp.Data = reader.GetDateTime("dt_compra");

                comp.Forneceddor = new FornecedorDTO();
                comp.Forneceddor.Id = reader.GetInt32("id_fornecedor");
                lista.Add(comp);
            }
            return lista;
        }
        public void Excluir(int id)
        {
            string script = @" DELETE FROM  `mydb`.`tb_compra WHERE id_compra = @id_compra 
                            ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_compra", id));




            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


    }
}
