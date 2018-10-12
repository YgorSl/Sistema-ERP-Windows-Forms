using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Cardapio
{
    public class CardapioBusiness
    {
        public int salvar(CardapioDTO dto)
        {
            CardapioDatabase salva = new CardapioDatabase();
            int salv = salva.Salvar(dto);
            return salv;
        }
        public void Remover(int id)
        {
            CardapioDatabase excluir = new CardapioDatabase();
            excluir.Remover(id);
            
        }

        public List<CardapioDTO> lista(string nome,string tamanho)
        {
            CardapioDatabase lista = new CardapioDatabase();
            return lista.Consultar(nome, tamanho);

        }
        public void Alterar(CardapioDTO dto)
        {
            CardapioDatabase db = new CardapioDatabase();
            db.Update(dto);
        }

    }
}
