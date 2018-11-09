using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Estoque
{
    public class EstoqueBusiness
    {
        public void Salvar(List<EstoqueDTO> estoques)
        {
            EstoqueDatabase db = new EstoqueDatabase();

            foreach (EstoqueDTO estoque in estoques)
            {
                db.Salvar(estoque);
            }
        }
        public List<EstoqueDTO> Listar()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            List<EstoqueDTO> estoque = db.Listar();

            return estoque;
        }
        public List<Estoque_View> Lista()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            List<Estoque_View> estoque = db.Lista();

            return estoque;
        }
        public void Excluir(int id)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Excluir(id);
        }
        public List<Estoque_View> Lista3()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            List<Estoque_View> estoque = db.Lista3();

            return estoque;
        }
    }
}
