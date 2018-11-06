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

        public int Salvar1(ProvedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.Salvar1(dto);
        }

        public void Alterar1(ProvedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            db.Alterar1(dto);
        }

        public void Excluir1(int id)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            db.Excluir1(id);
        }

        public List<ProvedorDTO> filtro1(string Nome, string Cnpj)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            List<ProvedorDTO> forn = db.filtro1(Nome, Cnpj);
            return forn;

        }
        public List<ProvedorDTO> Listar1()
        {
            FornecedorDatabase db = new FornecedorDatabase();
            List<ProvedorDTO> forn = db.Listar1();
            return forn;
        }

    }
}
