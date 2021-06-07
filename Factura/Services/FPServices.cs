using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class FPServices : Database, IRepsitory<Forma_de_Pago>
    {
        public bool Add(Forma_de_Pago item)
        {
            throw new NotImplementedException();
        }

        public bool Desactivar(Forma_de_Pago item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Forma_de_Pago item)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(int query, string value)
        {
            string cmd = "SELECT * FROM Forma_de_pago";
            return ExecuteRead(cmd);
        }
    }
}
