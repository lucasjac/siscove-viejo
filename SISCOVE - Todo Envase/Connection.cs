using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISCOVE___Todo_Envase
{
    public class Connection
    {
        private static string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=SISCOVE;Integrated Security=SSPI";
        public static string stringConnection
        {
            get { return connection; }
        }
    }
}
