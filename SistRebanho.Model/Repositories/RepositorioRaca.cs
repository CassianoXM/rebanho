using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistRebanho.Model.Helper;

namespace SistRebanho.Model.Repositories
{
    public class RepositorioRaca : IDisposable
    {
        private RebanhoEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositorioRaca()
        {
            odb = Data.getContexto();
            LiberaContexto = true;
        }

        public RepositorioRaca(RebanhoEntities obd)
        {
            obd = odb;
        }
        public List<RACA> SelecionarTodos(string Raca)
        {
            if (Raca.Trim() == "")
            {
                return (from p in odb.RACA orderby p.raca select p).ToList();
            }
            else
            {
                return (from p in odb.RACA where p.raca.Contains(Raca) select p).ToList();
            }
        }
        // ok
        public RACA SelecionarRaca(Int32 Raca)
        {
            return (from p in odb.RACA where p.id.Equals(Raca) select p).FirstOrDefault();
        }

        public RACA SelecionarID(int ID)
        {
            return (from p in odb.RACA where p.id == ID select p).FirstOrDefault();
        }

        public RACA Selecionar(int ID)
        {
            return (from p in odb.RACA where p.id == ID select p).FirstOrDefault();
        }

        public RACA Selecionar(int? ID)
        {
            return (from p in odb.RACA where p.id == ID select p).FirstOrDefault();
        }
        // ok
        public void Incluir(RACA oRaca)
        {
            odb.RACA.Add(oRaca);
            odb.SaveChanges();
        }

        public List<RACA> SelecionarTodos()
        {
            return odb.RACA.OrderBy(p => p.id).ToList();
        }

        public void Alterar(RACA oRaca, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oRaca).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(RACA oRaca)
        {
            odb.RACA.Attach(oRaca);
            odb.RACA.Remove(oRaca);
            odb.SaveChanges();
        }
        public void Dispose()
        {
            if (LiberaContexto)
            {
                odb.Dispose();
            }
        }
    }
}
