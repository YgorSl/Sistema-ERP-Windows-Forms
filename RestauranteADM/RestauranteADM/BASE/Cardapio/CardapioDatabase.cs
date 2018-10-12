using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Cardapio
{
    public class CardapioDatabase
    {
        public int Salvar(CardapioDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_cardapio` ( nm_prato, ds_prato, ds_tamanho, vl_valor) 
                                                        VALUES ( @nm_prato, @ds_prato, @ds_tamanho, @vl_valor);";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_prato", dto.nome_Prato));
            parms.Add(new MySqlParameter("ds_prato", dto.Descrição));
            parms.Add(new MySqlParameter("ds_tamanho", dto.Tamanho));
            parms.Add(new MySqlParameter("vl_valor", dto.Valor));
      

            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;
        }




        public void Update(CardapioDTO dto)
        {
            string script = @"UPDATE tb_cardapio SET nm_prato=@nm_prato, ds_prato=@ds_prato , ds_tamanho=@ds_tamanho , vl_valor=@vl_valor   where id_cardapio=@id_cardapio";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cardapio", dto.Id));
            parms.Add(new MySqlParameter("nm_prato", dto.nome_Prato));
            parms.Add(new MySqlParameter("ds_prato", dto.Descrição));
            parms.Add(new MySqlParameter("ds_tamanho", dto.Tamanho));
            parms.Add(new MySqlParameter("vl_valor", dto.Valor));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_cardapio WHERE  id_cardapio = @id_cardapio";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cardapio", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<CardapioDTO> Consultar(string nome, string tamanho)
        {


            string script = @"select *from tb_cardapio where nm_prato like @nome and ds_tamanho like @tamanho";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nome", "%" + nome + "%"));
            parms.Add(new MySqlParameter("tamanho", "%" + tamanho + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<CardapioDTO> lista = new List<CardapioDTO>();
            while (reader.Read())
            {
                CardapioDTO dto = new CardapioDTO();
                dto.Id = reader.GetInt32("id_cardapio");
                dto.nome_Prato = reader.GetString("nm_prato");
                dto.Descrição = reader.GetString("ds_prato");
                dto.Tamanho = reader.GetString("ds_tamanho");
                dto.Valor = reader.GetDouble("vl_valor");
                lista.Add(dto);
            }
            reader.Close();

            return lista;

        }
    }
}
