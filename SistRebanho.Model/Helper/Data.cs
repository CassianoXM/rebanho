using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistRebanho.Model.Helper
{
    public class Data
    {
        public static RebanhoEntities1 getContexto()
        {
            RebanhoEntities1 odb = new RebanhoEntities1(); // instancia a conexão com o Banco de dados
            odb.Configuration.ProxyCreationEnabled = false; // desabilita o proxy
            return odb; // retorna a conexão com Banco de Dados
        }
    }
}
