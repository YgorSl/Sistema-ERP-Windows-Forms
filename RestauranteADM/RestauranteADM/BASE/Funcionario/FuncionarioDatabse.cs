using MySql.Data.MySqlClient;
using RestauranteADM.BASE.Usuario;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Funcionario
{
    public class FuncionarioDatabse
    {

        public int Salvar(FuncionarioDTO dto)
        {
            string script = @"INSERT INTO `mydb`.`tb_funcionarios` (nm_nome, ds_cpf, ds_RG, ds_endereco, ds_salario,ds_gmail,ds_senha_recupecao) 
                                                            VALUES (@nm_nome, @ds_cpf, @ds_RG, @ds_endereco, @ds_salario,@ds_gmail,@ds_senha_recupecao)";





            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("ds_cpf", dto.Cpf));
            parms.Add(new MySqlParameter("ds_RG", dto.Rg));
            parms.Add(new MySqlParameter("ds_endereco", dto.Endereço));
            parms.Add(new MySqlParameter("ds_Salario", dto.Salario));
            parms.Add(new MySqlParameter("ds_gmail", dto.Gmail));
            parms.Add(new MySqlParameter("ds_senha_recupecao", dto.senha_recuperaçao));






            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }



        public List<FuncionarioDTO> filtro(string Nome)
        {
            string script = @"select * " +
                " from tb_funcionarios" +
                " inner join tb_permissao on tb_permissao.id_funcionario=tb_funcionarios.id_funcionarios" +
                " where nm_nome like @nome ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nome", "%" + Nome + "%"));




            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read() == true)
            {

                FuncionarioDTO funcio = new FuncionarioDTO();
                funcio.Id = reader.GetInt32("id_funcionarios");
                funcio.Nome = reader.GetString("nm_nome");
                funcio.Cpf = reader.GetString("ds_cpf");
                funcio.Rg = reader.GetString("ds_RG");
                funcio.Endereço = reader.GetString("ds_endereco");
                funcio.Salario = reader.GetDouble("ds_Salario");
                funcio.Gmail = reader.GetString("ds_gmail");
                funcio.senha_recuperaçao = reader.GetString("ds_senha_recupecao");

                funcio.eui = new UsuarioDTO();
                funcio.eui.usuario = new FuncionarioDTO();
                funcio.eui.usuario.Id = funcio.Id;

                funcio.eui.Id = reader.GetInt32("id_permissao");
                funcio.eui.login = reader.GetString("nm_login");
                funcio.eui.senha = reader.GetString("ds_senha");
                funcio.eui.permissaototal = reader.GetBoolean("perm_total");
                funcio.eui.permissaocadastro = reader.GetBoolean("perm_cadastro");
                funcio.eui.permissaovendas = reader.GetBoolean("perm_vendas");
                funcio.eui.permissaocompras = reader.GetBoolean("perm_compras");
                funcio.eui.permissaoRH = reader.GetBoolean("perm_rh");
                funcio.eui.permissaofinanceiro = reader.GetBoolean("perm_financeiro");






                lista.Add(funcio);

            }
            return lista;
        }

        public void Excluir(int id)
        {
            string script = @"DELETE FROM tb_funcionarios WHERE id_funcionarios = @id_funcionarios";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionarios", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }



        public void Update(FuncionarioDTO dto)
        {
            string script = @"UPDATE tb_funcionarios SET nm_nome = @nm_nome , ds_cpf = @ds_cpf, ds_RG =@ds_RG , ds_endereco = @ds_endereco , ds_salario=@ds_salario WHERE id_funcionarios = @id_funcionarios";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionarios", dto.Id));
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("ds_cpf", dto.Cpf));
            parms.Add(new MySqlParameter("ds_RG", dto.Rg));
            parms.Add(new MySqlParameter("ds_endereco", dto.Endereço));
            parms.Add(new MySqlParameter("ds_salario", dto.Salario));
            parms.Add(new MySqlParameter("ds_gmail", dto.Gmail));
            parms.Add(new MySqlParameter("ds_senha_recupecao", dto.senha_recuperaçao));







            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }
        public List<FuncionarioDTO> Listar()
        {
            string script = @"SELECT * FROM tb_funcionarios";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {
               
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id = reader.GetInt32("id_funcionarios");
                dto.Nome = reader.GetString("nm_nome");
                dto.Cpf = reader.GetString("ds_cpf");
                dto.Rg = reader.GetString("ds_RG");
                dto.Endereço = reader.GetString("ds_endereco");
                dto.Salario = reader.GetDouble("ds_salario");
                dto.Gmail = reader.GetString("ds_gmail");
                dto.senha_recuperaçao = reader.GetString("ds_senha_recupecao");



                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
