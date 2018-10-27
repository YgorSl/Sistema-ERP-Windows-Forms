using MySql.Data.MySqlClient;
using RestauranteADM.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Usuario
{
    public class UsuarioDatabase
    {

        UsuarioDTO dt = new UsuarioDTO();


        public int Salvar(UsuarioDTO dto)
        {
            string script = @"INSERT INTO tb_permissao ( nm_login, ds_senha , perm_total , perm_cadastro , perm_consulta, perm_vendas, perm_compras, perm_rh, perm_financeiro, perm_estoque, perm_cadastrarcliente, perm_cadastrarproduto, perm_cadastrarcardapio, perm_cadastrarfuncionario, perm_cadastrarpedido,perm_cadastrarvenda,perm_cadastrarfolha, perm_consultarcliente, perm_consultarfornecedor, perm_consultarproduto, perm_consultarcardapio, perm_consultarfuncionario, perm_consultarpedido, perm_consultarvenda, perm_consultarfolha, perm_alterarcliente, perm_alterarfornecedor, perm_alterarfuncionario, perm_alterarproduto, perm_alterarcardapio, perm_alterarpedido, perm_alterarvenda, perm_excluircliente, perm_excluirfornecedor, perm_excluirfuncionario, perm_excluirproduto, perm_excluircardapio, perm_excluirpedido, perm_excluirvenda, perm_excluirfolha) 
                                  VALUES ( @nm_login, @ds_senha , @perm_total , @perm_cadastro ,@perm_consulta ,@perm_vendas, @perm_compras, @perm_rh, @perm_financeiro,@perm_estoque, @perm_cadastrarcliente, @perm_cadastrarproduto,@perm_cadastrarcardapio,@perm_cadastrarfuncionario,@perm_cadastrarpedido,@perm_cadastrarvenda,@perm_cadastrarfolha, @perm_consultarcliente, @perm_consultarfornecedor, @perm_consultarproduto, @perm_consultarcardapio, @perm_consultarfuncionario, @perm_consultarpedido, @perm_consultarvenda, @perm_consultarfolha, @perm_alterarcliente, @perm_alterarfornecedor, @perm_alterarfuncionario, @perm_alterarproduto, @perm_alterarcardapio, @perm_alterarpedido, @perm_alterarvenda, @perm_excluircliente, @perm_excluirfornecedor, @perm_excluirfuncionario, @perm_excluirproduto, @perm_excluircardapio, @perm_excluirpedido, @perm_excluirvenda, @perm_excluirfolha)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_login", dto.login));
            parms.Add(new MySqlParameter("ds_senha", dto.senha));
            parms.Add(new MySqlParameter("perm_total", dto.permissaototal));
            parms.Add(new MySqlParameter("perm_cadastro", dto.permissaocadastro));
            parms.Add(new MySqlParameter("perm_consulta", dto.permissaoconsultar));
            parms.Add(new MySqlParameter("perm_vendas", dto.permissaovendas));
            parms.Add(new MySqlParameter("perm_compras", dto.permissaocompras));
            parms.Add(new MySqlParameter("perm_rh", dto.permissaoRH));
            parms.Add(new MySqlParameter("perm_financeiro", dto.permissaofinanceiro));
            parms.Add(new MySqlParameter("perm_estoque", dto.permissaoestoque));
            parms.Add(new MySqlParameter("perm_cadastrarcliente", dto.permissaocadastrarcliente));
            parms.Add(new MySqlParameter("perm_cadastrarfornecedor", dto.permissaocadastrarfornecedor));
            parms.Add(new MySqlParameter("perm_cadastrarproduto", dto.permissaocadastrarproduto));
            parms.Add(new MySqlParameter("perm_cadastrarcardapio", dto.permissaocadastrarcardapio));
            parms.Add(new MySqlParameter("perm_cadastrarfuncionario", dto.permissaocadastrarfuncionario));
            parms.Add(new MySqlParameter("perm_cadastrarpedido", dto.permissaocadastrarpedido));
            parms.Add(new MySqlParameter("perm_cadastrarvenda", dto.permissaocadastrarvenda));
            parms.Add(new MySqlParameter("perm_cadastrarfolha", dto.permissaocadastrarfolha));
            parms.Add(new MySqlParameter("perm_consultarcliente", dto.permissaoconsultarcliente));
            parms.Add(new MySqlParameter("perm_consultarfornecedor", dto.permissaoconsultarfornecedor));
            parms.Add(new MySqlParameter("perm_consultarfuncionario", dto.permissaoconsultarfuncionario));
            parms.Add(new MySqlParameter("perm_consultarproduto", dto.permissaoconsultarproduto));
            parms.Add(new MySqlParameter("perm_consultarcardapio", dto.permissaoconsultarcardapio));
            parms.Add(new MySqlParameter("perm_consultarpedido", dto.permissaoconsultarpedido));
            parms.Add(new MySqlParameter("perm_consultarvenda", dto.permissaoconsultarvenda));
            parms.Add(new MySqlParameter("perm_consultarfolha", dto.permissaoconsultarfolha));
            parms.Add(new MySqlParameter("perm_alterarcliente", dto.permissaoalterarcliente));
            parms.Add(new MySqlParameter("perm_alterarfornecedor", dto.permissaoalterarfornecedor));
            parms.Add(new MySqlParameter("perm_alterarfuncionario", dto.permissaoalterarfuncionario));
            parms.Add(new MySqlParameter("perm_alterarproduto", dto.permissaoalterarproduto));
            parms.Add(new MySqlParameter("perm_alterarcardapio", dto.permissaoalterarcardapio));
            parms.Add(new MySqlParameter("perm_alterarpedido", dto.permissaoalterarpedido));
            parms.Add(new MySqlParameter("perm_alterarvenda", dto.permissaoalterarvenda));
            parms.Add(new MySqlParameter("perm_excluircliente", dto.permissaoexcluircliente));
            parms.Add(new MySqlParameter("perm_excluirfornecedor", dto.permissaoexcluirfornecedor));
            parms.Add(new MySqlParameter("perm_excluirfuncionario", dto.permissaoexcluirfuncionario));
            parms.Add(new MySqlParameter("perm_excluirproduto", dto.permissaoexcluirproduto));
            parms.Add(new MySqlParameter("perm_excluircardapio", dto.permissaoexcluircardapio));
            parms.Add(new MySqlParameter("perm_excluirpedido", dto.permissaoexcluirpedido));
            parms.Add(new MySqlParameter("perm_excluirvenda", dto.permissaoexcluirvenda));
            parms.Add(new MySqlParameter("perm_excluirfolha", dto.permissaoexcluirfolha));



            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }


        internal UsuarioDatabase logar(string usuario, string senha)
        {
            throw new NotImplementedException();
        }

        public void Update(UsuarioDTO dto)
        {
            string script = @"UPDATE tb_permissao SET nm_login =@nm_login,ds_senha=@ds_senha, id_funcionario = @id_funcionario ,perm_total=@perm_total,perm_cadastro=@perm_cadastro, perm_consulta = @perm_consulta, perm_vendas=@perm_vendas,perm_compras=@perm_compras,perm_rh=@perm_rh,perm_financeiro=@perm_financeiro, perm_estoque = @perm_estoque, perm_cadastrarcliente = @perm_cadastrarcliente, perm_cadastrarfornecedor = @perm_cadastrarfornecedor, perm_cadastrarfuncionario = @cadastrarfuncionario, perm_cadastrarproduto = @perm_cadastrarproduto, perm_cadastrarcardapio = @perm_cadastrarcardapio, perm_cadastrarpedido = @perm_cadastrarpedido, perm_cadastrarvenda = @perm_cadastrarvenda, perm_cadastrarfolha = @permcadastrarfolha, perm_consultarcliente = @perm_consultarcliente, perm_consultarfornecedor = @perm_consultarfornecedor, perm_consultarfuncionario = @perm_consultarproduto, perm_consultarcardapio = @perm_consultarcardapio, perm_consultarpedido = @perm_consultarvenda, perm_consultarfolha = @perm_consultarfolha, perm_alterarcliente = @perm_alterarcliente, perm_alterarfornecedor = @perm_alterarfornecedor, perm_alterarfuncionario = @perm_alterarfuncionario, perm_alterarproduto = @perm_alterarproduto, perm_alterarcardapio = @perm_alterarcardapio, perm_alterarpedido = @perm_alterarpedido, perm_alterarpedido = @perm_alterarpedido, perm_alterarvenda = @permalterarvenda, perm_excluircliente = @perm_excluircliente, perm_excluirfornecedor = @perm_excluirfornecedor, perm_excluirfuncionario = @perm_excluirfuncionario, perm_excluirproduto = @perm_excluirproduto, perm_excluircardapio = @perm_excluircardapio, perm_excluirpedido = @perm_excluirpedido, perm_excluirvenda = @perm_excluirvenda, perm_excluirfolha = @perm_excluirfolha   WHERE id_permissao = @id_permissao";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_login", dto.login));
            parms.Add(new MySqlParameter("ds_senha", dto.senha));
            parms.Add(new MySqlParameter("perm_total", dto.permissaototal));
            parms.Add(new MySqlParameter("perm_cadastro", dto.permissaocadastro));
            parms.Add(new MySqlParameter("perm_consulta", dto.permissaoconsultar));
            parms.Add(new MySqlParameter("perm_vendas", dto.permissaovendas));
            parms.Add(new MySqlParameter("perm_compras", dto.permissaocompras));
            parms.Add(new MySqlParameter("perm_rh", dto.permissaoRH));
            parms.Add(new MySqlParameter("perm_financeiro", dto.permissaofinanceiro));
            parms.Add(new MySqlParameter("perm_estoque", dto.permissaoestoque));
            parms.Add(new MySqlParameter("perm_cadastrarcliente", dto.permissaocadastrarcliente));
            parms.Add(new MySqlParameter("perm_cadastrarfornecedor", dto.permissaocadastrarfornecedor));
            parms.Add(new MySqlParameter("perm_cadastrarproduto", dto.permissaocadastrarproduto));
            parms.Add(new MySqlParameter("perm_cadastrarcardapio", dto.permissaocadastrarcardapio));
            parms.Add(new MySqlParameter("perm_cadastrarfuncionario", dto.permissaocadastrarfuncionario));
            parms.Add(new MySqlParameter("perm_cadastrarpedido", dto.permissaocadastrarpedido));
            parms.Add(new MySqlParameter("perm_cadastrarvenda", dto.permissaocadastrarvenda));
            parms.Add(new MySqlParameter("perm_cadastrarfolha", dto.permissaocadastrarfolha));
            parms.Add(new MySqlParameter("perm_consultarcliente", dto.permissaoconsultarcliente));
            parms.Add(new MySqlParameter("perm_consultarfornecedor", dto.permissaoconsultarfornecedor));
            parms.Add(new MySqlParameter("perm_consultarfuncionario", dto.permissaoconsultarfuncionario));
            parms.Add(new MySqlParameter("perm_consultarproduto", dto.permissaoconsultarproduto));
            parms.Add(new MySqlParameter("perm_consultarcardapio", dto.permissaoconsultarcardapio));
            parms.Add(new MySqlParameter("perm_consultarpedido", dto.permissaoconsultarpedido));
            parms.Add(new MySqlParameter("perm_consultarvenda", dto.permissaoconsultarvenda));
            parms.Add(new MySqlParameter("perm_consultarfolha", dto.permissaoconsultarfolha));
            parms.Add(new MySqlParameter("perm_alterarcliente", dto.permissaoalterarcliente));
            parms.Add(new MySqlParameter("perm_alterarfornecedor", dto.permissaoalterarfornecedor));
            parms.Add(new MySqlParameter("perm_alterarfuncionario", dto.permissaoalterarfuncionario));
            parms.Add(new MySqlParameter("perm_alterarproduto", dto.permissaoalterarproduto));
            parms.Add(new MySqlParameter("perm_alterarcardapio", dto.permissaoalterarcardapio ));
            parms.Add(new MySqlParameter("perm_alterarpedido", dto.permissaoalterarpedido));
            parms.Add(new MySqlParameter("perm_alterarvenda", dto.permissaoalterarvenda));
            parms.Add(new MySqlParameter("perm_excluircliente", dto.permissaoexcluircliente));
            parms.Add(new MySqlParameter("perm_excluirfornecedor", dto.permissaoexcluirfornecedor));
            parms.Add(new MySqlParameter("perm_excluirfuncionario", dto.permissaoexcluirfuncionario));
            parms.Add(new MySqlParameter("perm_excluirproduto", dto.permissaoexcluirproduto));
            parms.Add(new MySqlParameter("perm_excluircardapio", dto.permissaoexcluircardapio));
            parms.Add(new MySqlParameter("perm_excluirpedido", dto.permissaoexcluirpedido));
            parms.Add(new MySqlParameter("perm_excluirvenda", dto.permissaoexcluirvenda));
            parms.Add(new MySqlParameter("perm_excluirfolha", dto.permissaoexcluirfolha));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_permissao WHERE id_usuario = @id_usuario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_usuario", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<UsuarioDTO> Consultar(string usuario)
        {
            string script = @"SELECT * FROM usuario WHERE nm_nome like @nome";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_login", usuario + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            while (reader.Read())
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.login = reader.GetString("nm_login");
                dto.senha = reader.GetString("ds_senha");
                dto.permissaototal = reader.GetBoolean("perm_total");
                dto.permissaocadastro = reader.GetBoolean("perm_cadastro");
                dto.permissaoconsultar = reader.GetBoolean("perm_consulta");
                dto.permissaovendas = reader.GetBoolean("perm_vendas");
                dto.permissaocompras = reader.GetBoolean("perm_compras");
                dto.permissaoRH = reader.GetBoolean("perm_rh");
                dto.permissaofinanceiro = reader.GetBoolean("perm_financeiro");
                dto.permissaoestoque = reader.GetBoolean("perm_estoque");
                dto.permissaocadastrarcliente = reader.GetBoolean("perm_cadastrarcliente");
                dto.permissaocadastrarfornecedor = reader.GetBoolean("perm_cadastrarfornecedor");
                dto.permissaocadastrarfuncionario = reader.GetBoolean("perm_cadastrarfuncionario");
                dto.permissaocadastrarproduto = reader.GetBoolean("perm_cadastrarproduto");
                dto.permissaocadastrarcardapio = reader.GetBoolean("perm_cadastrarcardapio");
                dto.permissaocadastrarpedido = reader.GetBoolean("perm_cadastrarpedido");
                dto.permissaoconsultarcliente = reader.GetBoolean("perm_consultarcliente");
                dto.permissaoconsultarfornecedor = reader.GetBoolean("perm_consultarfornecedor");
                dto.permissaoconsultarfuncionario = reader.GetBoolean("perm_consultarfuncionario");
                dto.permissaoconsultarproduto = reader.GetBoolean("perm_consultarproduto");
                dto.permissaoconsultarcardapio = reader.GetBoolean("perm_consultarcardapio");
                dto.permissaoconsultarpedido = reader.GetBoolean("perm_consultarpedido");
                dto.permissaoconsultarvenda = reader.GetBoolean("perm_consultarvenda");
                dto.permissaoconsultarfolha = reader.GetBoolean("perm_consultarfolha");
                dto.permissaoalterarcliente = reader.GetBoolean("perm_alterarcliente");
                dto.permissaoalterarfornecedor = reader.GetBoolean("perm_alterarfornecedor");
                dto.permissaoalterarfuncionario = reader.GetBoolean("perm_alterarfuncionario");
                dto.permissaoalterarproduto = reader.GetBoolean("perm_alterarproduto");
                dto.permissaoalterarcardapio = reader.GetBoolean("perm_alterarcardapio");
                dto.permissaoalterarpedido = reader.GetBoolean("perm_alterarpedido");
                dto.permissaoalterarvenda = reader.GetBoolean("perm_alterarvenda");
                dto.permissaoexcluircliente = reader.GetBoolean("perm_excluircliente");
                dto.permissaoexcluirfornecedor = reader.GetBoolean("perm_excluirfornecedor");
                dto.permissaoexcluirfuncionario = reader.GetBoolean("perm_excluirfuncionario");
                dto.permissaoexcluirproduto = reader.GetBoolean("perm_excluirproduto");
                dto.permissaoexcluircardapio = reader.GetBoolean("perm_excluircardapio");
                dto.permissaoexcluirpedido = reader.GetBoolean("perm_excluirpedido");
                dto.permissaoexcluircliente = reader.GetBoolean("perm_excluirvenda");
                dto.permissaoexcluircliente = reader.GetBoolean("perm_excluirfolha");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
        public List<UsuarioDTO> Listar()
        {
            string script = @"SELECT * FROM tb_permissao";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            while (reader.Read())
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.login = reader.GetString("nm_login");
                dto.senha = reader.GetString("ds_senha");
                dto.permissaototal = reader.GetBoolean("perm_total");
                dto.permissaocadastro = reader.GetBoolean("perm_cadastro");
                dto.permissaoconsultar = reader.GetBoolean("perm_consulta");
                dto.permissaovendas = reader.GetBoolean("perm_vendas");
                dto.permissaocompras = reader.GetBoolean("perm_compras");
                dto.permissaoRH = reader.GetBoolean("perm_rh");
                dto.permissaofinanceiro = reader.GetBoolean("perm_financeiro");
                dto.permissaoestoque = reader.GetBoolean("perm_estoque");
                dto.permissaocadastrarcliente = reader.GetBoolean("perm_cadastrarcliente");
                dto.permissaocadastrarfornecedor = reader.GetBoolean("perm_cadastrarfornecedor");
                dto.permissaocadastrarfuncionario = reader.GetBoolean("perm_cadastrarfuncionario");
                dto.permissaocadastrarproduto = reader.GetBoolean("perm_cadastrarproduto");
                dto.permissaocadastrarcardapio = reader.GetBoolean("perm_cadastrarcardapio");
                dto.permissaocadastrarpedido = reader.GetBoolean("perm_cadastrarpedido");
                dto.permissaoconsultarcliente = reader.GetBoolean("perm_consultarcliente");
                dto.permissaoconsultarfornecedor = reader.GetBoolean("perm_consultarfornecedor");
                dto.permissaoconsultarfuncionario = reader.GetBoolean("perm_consultarfuncionario");
                dto.permissaoconsultarproduto = reader.GetBoolean("perm_consultarproduto");
                dto.permissaoconsultarcardapio = reader.GetBoolean("perm_consultarcardapio");
                dto.permissaoconsultarpedido = reader.GetBoolean("perm_consultarpedido");
                dto.permissaoconsultarvenda = reader.GetBoolean("perm_consultarvenda");
                dto.permissaoconsultarfolha = reader.GetBoolean("perm_consultarfolha");
                dto.permissaoalterarcliente = reader.GetBoolean("perm_alterarcliente");
                dto.permissaoalterarfornecedor = reader.GetBoolean("perm_alterarfornecedor");
                dto.permissaoalterarfuncionario = reader.GetBoolean("perm_alterarfuncionario");
                dto.permissaoalterarproduto = reader.GetBoolean("perm_alterarproduto");
                dto.permissaoalterarcardapio = reader.GetBoolean("perm_alterarcardapio");
                dto.permissaoalterarpedido = reader.GetBoolean("perm_alterarpedido");
                dto.permissaoalterarvenda = reader.GetBoolean("perm_alterarvenda");
                dto.permissaoexcluircliente = reader.GetBoolean("perm_excluircliente");
                dto.permissaoexcluirfornecedor = reader.GetBoolean("perm_excluirfornecedor");
                dto.permissaoexcluirfuncionario = reader.GetBoolean("perm_excluirfuncionario");
                dto.permissaoexcluirproduto = reader.GetBoolean("perm_excluirproduto");
                dto.permissaoexcluircardapio = reader.GetBoolean("perm_excluircardapio");
                dto.permissaoexcluirpedido = reader.GetBoolean("perm_excluirpedido");
                dto.permissaoexcluircliente = reader.GetBoolean("perm_excluirvenda");
                dto.permissaoexcluircliente = reader.GetBoolean("perm_excluirfolha");

            }
            reader.Close();

            return lista;
        }


        public UsuarioDTO Logar(string login, string senha)
        {

            string script =
                @"select * from tb_permissao where nm_login = @nm_login and ds_senha = @ds_senha";



            List<MySqlParameter> parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("nm_login", login));
            parametros.Add(new MySqlParameter("ds_senha", senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parametros);

            UsuarioDTO dt = new UsuarioDTO();

            if (reader.Read() == true)
            {

                dt = new UsuarioDTO();
                dt.login = reader.GetString("nm_login");
                dt.senha = reader.GetString("ds_senha");
                dt.permissaototal = reader.GetBoolean("perm_total");
                dt.permissaocadastro = reader.GetBoolean("perm_cadastro");
                dt.permissaoconsultar = reader.GetBoolean("perm_consulta");
                dt.permissaovendas = reader.GetBoolean("perm_vendas");
                dt.permissaocompras = reader.GetBoolean("perm_compras");
                dt.permissaoRH = reader.GetBoolean("perm_rh");
                dt.permissaofinanceiro = reader.GetBoolean("perm_financeiro");
                dt.permissaoestoque = reader.GetBoolean("perm_estoque");
                dt.permissaocadastrarcliente = reader.GetBoolean("perm_cadastrarcliente");
                dt.permissaocadastrarfornecedor = reader.GetBoolean("perm_cadastrarfornecedor");
                dt.permissaocadastrarfuncionario = reader.GetBoolean("perm_cadastrarfuncionario");
                dt.permissaocadastrarproduto = reader.GetBoolean("perm_cadastrarproduto");
                dt.permissaocadastrarcardapio = reader.GetBoolean("perm_cadastrarcardapio");
                dt.permissaocadastrarpedido = reader.GetBoolean("perm_cadastrarpedido");
                dt.permissaoconsultarcliente = reader.GetBoolean("perm_consultarcliente");
                dt.permissaoconsultarfornecedor = reader.GetBoolean("perm_consultarfornecedor");
                dt.permissaoconsultarfuncionario = reader.GetBoolean("perm_consultarfuncionario");
                dt.permissaoconsultarproduto = reader.GetBoolean("perm_consultarproduto");
                dt.permissaoconsultarcardapio = reader.GetBoolean("perm_consultarcardapio");
                dt.permissaoconsultarpedido = reader.GetBoolean("perm_consultarpedido");
                dt.permissaoconsultarvenda = reader.GetBoolean("perm_consultarvenda");
                dt.permissaoconsultarfolha = reader.GetBoolean("perm_consultarfolha");
                dt.permissaoalterarcliente = reader.GetBoolean("perm_alterarcliente");
                dt.permissaoalterarfornecedor = reader.GetBoolean("perm_alterarfornecedor");
                dt.permissaoalterarfuncionario = reader.GetBoolean("perm_alterarfuncionario");
                dt.permissaoalterarproduto = reader.GetBoolean("perm_alterarproduto");
                dt.permissaoalterarcardapio = reader.GetBoolean("perm_alterarcardapio");
                dt.permissaoalterarpedido = reader.GetBoolean("perm_alterarpedido");
                dt.permissaoalterarvenda = reader.GetBoolean("perm_alterarvenda");
                dt.permissaoexcluircliente = reader.GetBoolean("perm_excluircliente");
                dt.permissaoexcluirfornecedor = reader.GetBoolean("perm_excluirfornecedor");
                dt.permissaoexcluirfuncionario = reader.GetBoolean("perm_excluirfuncionario");
                dt.permissaoexcluirproduto = reader.GetBoolean("perm_excluirproduto");
                dt.permissaoexcluircardapio = reader.GetBoolean("perm_excluircardapio");
                dt.permissaoexcluirpedido = reader.GetBoolean("perm_excluirpedido");
                dt.permissaoexcluircliente = reader.GetBoolean("perm_excluirvenda");
                dt.permissaoexcluircliente = reader.GetBoolean("perm_excluirfolha");
            }
            reader.Close();
            return dt;
        }

        public void Salvor(UsuarioDTO dto)
        {
            string script = @"INSERT INTO tb_permissao ( nm_login, ds_senha , perm_total , perm_cadastro , perm_consulta, perm_vendas, perm_compras, perm_rh, perm_financeiro, perm_estoque, perm_cadastrarcliente, perm_cadastrarproduto, perm_cadastrarcardapio, perm_cadastrarfuncionario, perm_cadastrarpedido,perm_cadastrarvenda,perm_cadastrarfolha, perm_consultarcliente, perm_consultarfornecedor, perm_consultarproduto, perm_consultarcardapio, perm_consultarfuncionario, perm_consultarpedido, perm_consultarvenda, perm_consultarfolha, perm_alterarcliente, perm_alterarfornecedor, perm_alterarfuncionario, perm_alterarproduto, perm_alterarcardapio, perm_alterarpedido, perm_alterarvenda, perm_excluircliente, perm_excluirfornecedor, perm_excluirfuncionario, perm_excluirproduto, perm_excluircardapio, perm_excluirpedido, perm_excluirvenda, perm_excluirfolha) 
                                  VALUES ( @nm_login, @ds_senha , @perm_total , @perm_cadastro ,@perm_consulta ,@perm_vendas, @perm_compras, @perm_rh, @perm_financeiro,@perm_estoque, @perm_cadastrarcliente, @perm_cadastrarproduto,@perm_cadastrarcardapio,@perm_cadastrarfuncionario,@perm_cadastrarpedido,@perm_cadastrarvenda,@perm_cadastrarfolha, @perm_consultarcliente, @perm_consultarfornecedor, @perm_consultarproduto, @perm_consultarcardapio, @perm_consultarfuncionario, @perm_consultarpedido, @perm_consultarvenda, @perm_consultarfolha, @perm_alterarcliente, @perm_alterarfornecedor, @perm_alterarfuncionario, @perm_alterarproduto, @perm_alterarcardapio, @perm_alterarpedido, @perm_alterarvenda, @perm_excluircliente, @perm_excluirfornecedor, @perm_excluirfuncionario, @perm_excluirproduto, @perm_excluircardapio, @perm_excluirpedido, @perm_excluirvenda, @perm_excluirfolha)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_login", dto.login));
            parms.Add(new MySqlParameter("ds_senha", dto.senha));
            parms.Add(new MySqlParameter("perm_total", dto.permissaototal));
            parms.Add(new MySqlParameter("perm_cadastro", dto.permissaocadastro));
            parms.Add(new MySqlParameter("perm_consulta", dto.permissaoconsultar));
            parms.Add(new MySqlParameter("perm_vendas", dto.permissaovendas));
            parms.Add(new MySqlParameter("perm_compras", dto.permissaocompras));
            parms.Add(new MySqlParameter("perm_rh", dto.permissaoRH));
            parms.Add(new MySqlParameter("perm_financeiro", dto.permissaofinanceiro));
            parms.Add(new MySqlParameter("perm_estoque", dto.permissaoestoque));
            parms.Add(new MySqlParameter("perm_cadastrarcliente", dto.permissaocadastrarcliente));
            parms.Add(new MySqlParameter("perm_cadastrarfornecedor", dto.permissaocadastrarfornecedor));
            parms.Add(new MySqlParameter("perm_cadastrarproduto", dto.permissaocadastrarproduto));
            parms.Add(new MySqlParameter("perm_cadastrarcardapio", dto.permissaocadastrarcardapio));
            parms.Add(new MySqlParameter("perm_cadastrarfuncionario", dto.permissaocadastrarfuncionario));
            parms.Add(new MySqlParameter("perm_cadastrarpedido", dto.permissaocadastrarpedido));
            parms.Add(new MySqlParameter("perm_cadastrarvenda", dto.permissaocadastrarvenda));
            parms.Add(new MySqlParameter("perm_cadastrarfolha", dto.permissaocadastrarfolha));
            parms.Add(new MySqlParameter("perm_consultarcliente", dto.permissaoconsultarcliente));
            parms.Add(new MySqlParameter("perm_consultarfornecedor", dto.permissaoconsultarfornecedor));
            parms.Add(new MySqlParameter("perm_consultarfuncionario", dto.permissaoconsultarfuncionario));
            parms.Add(new MySqlParameter("perm_consultarproduto", dto.permissaoconsultarproduto));
            parms.Add(new MySqlParameter("perm_consultarcardapio", dto.permissaoconsultarcardapio));
            parms.Add(new MySqlParameter("perm_consultarpedido", dto.permissaoconsultarpedido));
            parms.Add(new MySqlParameter("perm_consultarvenda", dto.permissaoconsultarvenda));
            parms.Add(new MySqlParameter("perm_consultarfolha", dto.permissaoconsultarfolha));
            parms.Add(new MySqlParameter("perm_alterarcliente", dto.permissaoalterarcliente));
            parms.Add(new MySqlParameter("perm_alterarfornecedor", dto.permissaoalterarfornecedor));
            parms.Add(new MySqlParameter("perm_alterarfuncionario", dto.permissaoalterarfuncionario));
            parms.Add(new MySqlParameter("perm_alterarproduto",dto.permissaoalterarproduto));
            parms.Add(new MySqlParameter("perm_alterarcardapio", dto.permissaoalterarcardapio));
            parms.Add(new MySqlParameter("perm_alterarpedido", dto.permissaoalterarpedido));
            parms.Add(new MySqlParameter("perm_alterarvenda", dto.permissaoalterarvenda));
            parms.Add(new MySqlParameter("perm_excluircliente", dto.permissaoexcluircliente));
            parms.Add(new MySqlParameter("perm_excluirfornecedor", dto.permissaoexcluirfornecedor));
            parms.Add(new MySqlParameter("perm_excluirfuncionario", dto.permissaoexcluirfuncionario));
            parms.Add(new MySqlParameter("perm_excluirproduto", dto.permissaoexcluirproduto));
            parms.Add(new MySqlParameter("perm_excluircardapio", dto.permissaoexcluircardapio));
            parms.Add(new MySqlParameter("perm_excluirpedido", dto.permissaoexcluirpedido));
            parms.Add(new MySqlParameter("perm_excluirvenda", dto.permissaoexcluirvenda));
            parms.Add(new MySqlParameter("perm_excluirfolha", dto.permissaoexcluirfolha));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void Alteraçao(UsuarioDTO dto)
        {
            string script = @"UPDATE tb_permissao SET nm_login =@nm_login,ds_senha=@ds_senha, id_funcionario = @id_funcionario ,perm_total=@perm_total,perm_cadastro=@perm_cadastro,perm_vendas=@perm_vendas,perm_compras=@perm_compras,perm_rh=@perm_rh,perm_financeiro=@perm_financeiro WHERE id_permissao = @id_permissao";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_permissao", dto.Id));
            parms.Add(new MySqlParameter("id_funcionario", dto.usuario.Id));
            parms.Add(new MySqlParameter("nm_login", dto.login));
            parms.Add(new MySqlParameter("ds_senha", dto.senha));
            parms.Add(new MySqlParameter("perm_total", dto.permissaototal));
            parms.Add(new MySqlParameter("perm_cadastro", dto.permissaocadastro));
            parms.Add(new MySqlParameter("perm_consulta", dto.permissaoconsultar));
            parms.Add(new MySqlParameter("perm_vendas", dto.permissaovendas));
            parms.Add(new MySqlParameter("perm_compras", dto.permissaocompras));
            parms.Add(new MySqlParameter("perm_rh", dto.permissaoRH));
            parms.Add(new MySqlParameter("perm_financeiro", dto.permissaofinanceiro));
            parms.Add(new MySqlParameter("perm_estoque", dto.permissaoestoque));
            parms.Add(new MySqlParameter("perm_cadastrarcliente", dto.permissaocadastrarcliente));
            parms.Add(new MySqlParameter("perm_cadastrarfornecedor", dto.permissaocadastrarfornecedor));
            parms.Add(new MySqlParameter("perm_cadastrarproduto", dto.permissaocadastrarproduto));
            parms.Add(new MySqlParameter("perm_cadastrarcardapio", dto.permissaocadastrarcardapio));
            parms.Add(new MySqlParameter("perm_cadastrarfuncionario", dto.permissaocadastrarfuncionario));
            parms.Add(new MySqlParameter("perm_cadastrarpedido", dto.permissaocadastrarpedido));
            parms.Add(new MySqlParameter("perm_cadastrarvenda", dto.permissaocadastrarvenda));
            parms.Add(new MySqlParameter("perm_cadastrarfolha", dto.permissaocadastrarfolha));
            parms.Add(new MySqlParameter("perm_consultarcliente", dto.permissaoconsultarcliente));
            parms.Add(new MySqlParameter("perm_consultarfornecedor", dto.permissaoconsultarfornecedor));
            parms.Add(new MySqlParameter("perm_consultarfuncionario", dto.permissaoconsultarfuncionario));
            parms.Add(new MySqlParameter("perm_consultarproduto", dto.permissaoconsultarproduto));
            parms.Add(new MySqlParameter("perm_consultarcardapio", dto.permissaoconsultarcardapio));
            parms.Add(new MySqlParameter("perm_consultarpedido", dto.permissaoconsultarpedido));
            parms.Add(new MySqlParameter("perm_consultarvenda", dto.permissaoconsultarvenda));
            parms.Add(new MySqlParameter("perm_consultarfolha", dto.permissaoconsultarfolha));
            parms.Add(new MySqlParameter("perm_alterarcliente", dto.permissaoalterarcliente));
            parms.Add(new MySqlParameter("perm_alterarfornecedor", dto.permissaoalterarfornecedor));
            parms.Add(new MySqlParameter("perm_alterarfuncionario", dto.permissaoalterarfuncionario));
            parms.Add(new MySqlParameter("perm_alterarproduto", dto.permissaoalterarproduto));
            parms.Add(new MySqlParameter("perm_alterarpedido", dto.permissaoalterarpedido));
            parms.Add(new MySqlParameter("perm_alterarvenda", dto.permissaoalterarvenda));
            parms.Add(new MySqlParameter("perm_excluircliente", dto.permissaoexcluircliente));
            parms.Add(new MySqlParameter("perm_excluirfornecedor", dto.permissaoexcluirfornecedor));
            parms.Add(new MySqlParameter("perm_excluirfuncionario", dto.permissaoexcluirfuncionario));
            parms.Add(new MySqlParameter("perm_excluirproduto", dto.permissaoexcluirproduto));
            parms.Add(new MySqlParameter("perm_excluircardapio", dto.permissaoexcluircardapio));
            parms.Add(new MySqlParameter("perm_excluirpedido", dto.permissaoexcluirpedido));
            parms.Add(new MySqlParameter("perm_excluirvenda", dto.permissaoexcluirvenda));
            parms.Add(new MySqlParameter("perm_excluirfolha", dto.permissaoexcluirfolha));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);

        }
    }
}

    






    

