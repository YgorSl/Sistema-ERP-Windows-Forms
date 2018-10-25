using RestauranteADM.BASE.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Usuario
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string Observacao { get; set; }
        public int IdFuncionario { get; set; }
        public bool permissaototal { get; set; }
        public bool permissaoRH { get; set; }
        public bool permissaofinanceiro { get; set; }
        public bool permissaovendas { get; set; }
        public bool permissaocompras { get; set; }
        public bool permissaocadastro { get; set; }
        public bool permissaoconsultar { get; set; }
        public bool permissaoestoque { get; set; }
        public bool permissaocadastrarcliente { get; set; }
        public bool permissaocadastrarproduto { get; set; }
        public bool permissaocadastrarfuncionario { get; set; }
        public bool permissaocadastrarfornecedor { get; set; }
        public bool permissaocadastrarcardapio { get; set; }
        public bool permissaocadastrarpedido { get; set; }
        public bool permissaocadastrarvenda { get; set; }
        public bool permissaocadastrarfolha { get; set; }
        public bool permissaoconsultarcliente { get; set; }
        public bool permissaoconsultarfornecedor { get; set; }
        public bool permissaoconsultarusuario { get; set; }
        public bool permissaoconsultarproduto { get; set; }
        public bool permissaoconsultarcardapio { get; set; }
        public bool permissaoconsultarfuncionario { get; set; }
        public bool permissaoconsultarpedido { get; set; }
        public bool permissaoconsultarvenda { get; set; }
        public bool permissaoconsultarfolha { get; set; }
        public bool permissaoalterarcliente { get; set; }
        public bool permissaoalterarfornecedor { get; set; }
        public bool permissaoalterarusuario { get; set; }
        public bool permissaoalterarproduto { get; set; }
        public bool permissaoalterarcardapio { get; set; }
        public bool permissaoalterarfuncionario { get; set; }
        public bool permissaoalterarpedido { get; set; }
        public bool permissaoalterarvenda { get; set; }
        public bool permissaoexcluircliente { get; set; }
        public bool permissaoexcluirfornecedor { get; set; }
        public bool permissaoexcluirusuario { get; set; }
        public bool permissaoexcluirproduto { get; set; }
        public bool permissaoexcluircardapio { get; set; }
        public bool permissaoexcluirfuncionario { get; set; }
        public bool permissaoexcluirpedido { get; set; }
        public bool permissaoexcluirvenda { get; set; }
        public bool permissaoexcluirfolha { get; set; }


        public FuncionarioDTO usuario { get; set; }

    }
  
}
