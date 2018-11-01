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
            string script = @"INSERT INTO `mydb`.`tb_funcionarios` (nm_nome, ds_cpf, ds_RG, ds_salario,ds_gmail,ds_senha_recupecao,ds_Cep,nm_Cidade,nm_Bairro,nm_Rua,nm_local) 
                                                            VALUES (@nm_nome, @ds_cpf, @ds_RG, @ds_salario,@ds_gmail,@ds_senha_recupecao,@ds_Cep,@nm_Cidade,@nm_Bairro,@nm_Rua,@nm_local)";





            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", dto.Nome));
            parms.Add(new MySqlParameter("ds_cpf", dto.Cpf));
            parms.Add(new MySqlParameter("ds_RG", dto.Rg));
            parms.Add(new MySqlParameter("ds_Salario", dto.Salario));
            parms.Add(new MySqlParameter("ds_gmail", dto.Gmail));
            parms.Add(new MySqlParameter("ds_senha_recupecao", dto.senha_recuperaçao));
            parms.Add(new MySqlParameter("ds_Cep", dto.Cep));
            parms.Add(new MySqlParameter("nm_Cidade", dto.Rua));
            parms.Add(new MySqlParameter("nm_Bairro", dto.Bairro));
            parms.Add(new MySqlParameter("nm_Rua", dto.Rua));
            parms.Add(new MySqlParameter("nm_local", dto.N_local));









            Database db = new Database();
            int pk = db.ExecuteInsertScriptWithPk(script, parms);
            return pk;

        }



        public List<FuncionarioDTO> filtro(string Nome,string cpf)
        {
            string script = @"select * " +
                " from tb_funcionarios" +
                " inner join tb_permissao on tb_permissao.id_funcionario=tb_funcionarios.id_funcionarios" +
                " where nm_nome like @nome and ds_cpf like @cpf";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nome", "%" + Nome + "%"));
            parms.Add(new MySqlParameter("cpf", "%" + cpf + "%"));



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
                funcio.Salario = reader.GetDouble("ds_Salario");
                funcio.Gmail = reader.GetString("ds_gmail");
                funcio.senha_recuperaçao = reader.GetString("ds_senha_recupecao");
                funcio.Cep = reader.GetString("ds_Salario");
                funcio.Cidade = reader.GetString("nm_Cidade");
                funcio.Bairro = reader.GetString("nm_bairro");
                funcio.Rua = reader.GetString("nm_Rua");
                funcio.N_local= reader.GetString("nm_local");



                funcio.eui = new UsuarioDTO();
                funcio.eui.usuario = new FuncionarioDTO();
                funcio.eui.usuario.Id = funcio.Id;

                funcio.eui.Id = reader.GetInt32("id_permissao");
                funcio.eui.login = reader.GetString("nm_login");
                funcio.eui.senha = reader.GetString("ds_senha");
                funcio.eui.permissaototal = reader.GetBoolean("perm_total");
                funcio.eui.permissaocadastro = reader.GetBoolean("perm_cadastro");
                funcio.eui.permissaoconsultar = reader.GetBoolean("perm_consulta");
                funcio.eui.permissaovendas = reader.GetBoolean("perm_vendas");
                funcio.eui.permissaocompras = reader.GetBoolean("perm_compras");
                funcio.eui.permissaoRH = reader.GetBoolean("perm_rh");
                funcio.eui.permissaofinanceiro = reader.GetBoolean("perm_financeiro");
                funcio.eui.permissaoestoque = reader.GetBoolean("perm_estoque");
                funcio.eui.permissaocadastrarcliente = reader.GetBoolean("perm_cadastrarcliente");
                funcio.eui.permissaocadastrarfornecedor = reader.GetBoolean("perm_cadastrarfornecedor");
                funcio.eui.permissaocadastrarfuncionario = reader.GetBoolean("perm_cadastrarfuncionario");
                funcio.eui.permissaocadastrarproduto = reader.GetBoolean("perm_cadastrarproduto");
                funcio.eui.permissaocadastrarcardapio = reader.GetBoolean("perm_cadastrarcardapio");
                funcio.eui.permissaocadastrarpedido = reader.GetBoolean("perm_cadastrarpedido");
                funcio.eui.permissaoconsultarcliente = reader.GetBoolean("perm_consultarcliente");
                funcio.eui.permissaoconsultarfornecedor = reader.GetBoolean("perm_consultarfornecedor");
                funcio.eui.permissaoconsultarfuncionario = reader.GetBoolean("perm_consultarfuncionario");
                funcio.eui.permissaoconsultarproduto = reader.GetBoolean("perm_consultarproduto");
                funcio.eui.permissaoconsultarcardapio = reader.GetBoolean("perm_consultarcardapio");
                funcio.eui.permissaoconsultarpedido = reader.GetBoolean("perm_consultarpedido");
                funcio.eui.permissaoconsultarvenda = reader.GetBoolean("perm_consultarvenda");
                funcio.eui.permissaoconsultarfolha = reader.GetBoolean("perm_consultarfolha");
                funcio.eui.permissaoalterarcliente = reader.GetBoolean("perm_alterarcliente");
                funcio.eui.permissaoalterarfornecedor = reader.GetBoolean("perm_alterarfornecedor");
                funcio.eui.permissaoalterarfuncionario = reader.GetBoolean("perm_alterarfuncionario");
                funcio.eui.permissaoalterarproduto = reader.GetBoolean("perm_alterarproduto");
                funcio.eui.permissaoalterarcardapio = reader.GetBoolean("perm_alterarcardapio");
                funcio.eui.permissaoalterarpedido = reader.GetBoolean("perm_alterarpedido");
                funcio.eui.permissaoalterarvenda = reader.GetBoolean("perm_alterarvenda");
                funcio.eui.permissaoexcluircliente = reader.GetBoolean("perm_excluircliente");
                funcio.eui.permissaoexcluirfornecedor = reader.GetBoolean("perm_excluirfornecedor");
                funcio.eui.permissaoexcluirfuncionario = reader.GetBoolean("perm_excluirfuncionario");
                funcio.eui.permissaoexcluirproduto = reader.GetBoolean("perm_excluirproduto");
                funcio.eui.permissaoexcluircardapio = reader.GetBoolean("perm_excluircardapio");
                funcio.eui.permissaoexcluirpedido = reader.GetBoolean("perm_excluirpedido");
                funcio.eui.permissaoexcluircliente = reader.GetBoolean("perm_excluirvenda");
                funcio.eui.permissaoexcluircliente = reader.GetBoolean("perm_excluirfolha");





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
