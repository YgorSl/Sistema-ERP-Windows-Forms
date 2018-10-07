using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteADM.BASE.Fornecedor
{
    class FornecedorBusiness
    {
        public int Salvar(FornecedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.Salvar(dto);
        }

        public void Alterar(FornecedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            db.Alterar(dto);
        }

        public void Excluir(int id)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            db.Excluir(id);
        }

        public List<FornecedorDTO> filtro(string Nome, string Cnpj)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            List<FornecedorDTO> forn = db.filtro(Nome, Cnpj);
            return forn;
            
        }
        public List<FornecedorDTO> Listar()
        {
            FornecedorDatabase db = new FornecedorDatabase();
            List<FornecedorDTO> forn = db.Listar();
            return forn;
        }



    }
}
