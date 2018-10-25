using RestauranteADM.BASE.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Produto
{
    public class CompraItemBusiness
    {
        public void Salvar(CompraItemDTO item)
        {
            CompraItemDatabase db = new CompraItemDatabase();
            db.Salvar(item);
        }
        public List<VerView> Filtro(int forn)
        {
            CompraItemDatabase db = new CompraItemDatabase();
            List<VerView> items = db.Filtro(forn);
            return items;
        }
        public List<CompraItemDTO> Filtro1(int compraid)
        {
            CompraItemDatabase db = new CompraItemDatabase();
            List<CompraItemDTO> items = db.Filtro1(compraid);
            return items;
        }
        public void Excluir(int id)
        {
            CompraItemDatabase db = new CompraItemDatabase();
            db.Excluir(id);
        }
    }
}
