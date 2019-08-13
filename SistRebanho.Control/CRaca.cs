using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistRebanho.Model;
using SistRebanho.Model.Repositories;


namespace Rebanho.Control
{
    public class CRaca
    {
        RepositorioRaca _Repository;
        public CRaca()
        {
            _Repository = new RepositorioRaca();
        }
        public void Incluir(RACA oRaca)
        {
            _Repository.Incluir(oRaca);
        }
        public void Excluir(RACA oRaca)
        {
            _Repository.Excluir(oRaca);
        }
        public RACA Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }
        public RACA SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        public List<RACA> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }
        public void Dispose()
        {
            _Repository.Dispose();
        }
    }
}
