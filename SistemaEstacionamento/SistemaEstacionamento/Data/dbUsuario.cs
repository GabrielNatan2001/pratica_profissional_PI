using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Data
{
    public class dbUsuario
    {
        public string authenticarUsuario(string login, string senha)
        {
            string sql = "select id from usuario" +
                         " where nome ='" + login + "' and senha= '" + senha + "'";

            return sql;
        }
    }
}
