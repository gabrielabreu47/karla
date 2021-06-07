using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Factura
{
    public class Detailbuyservices : Database, IRepsitory<Detallescompra>
    {
        public bool Add(Detallescompra item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Detalles_Compras (Cod_Comp, ID_Pro, Cantidad) "
                                             + "VALUES(@Cod_Comp, @ID_Pro, @Cantidad)");
            command.Parameters.AddWithValue("@Cod_Comp", item.Cod_Comp);
            command.Parameters.AddWithValue("@ID_Pro", item.ID_Pro);
            command.Parameters.AddWithValue("@Cantidad", item.Cantidad);

            return ExecuteDml(command);

        }

        public bool Desactivar(Detallescompra item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Detallescompra item)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(int query, string value)
        {
            string cmd = "";
            if (query == 0)
            {
                cmd = "SELECT * FROM Detalles_Compra";
            }
            else
            {
                cmd = "SELECT * FROM Detalles_Compra WHERE Cod_Comp = " + value;
            }
            return ExecuteRead(cmd);
        }
    }
}
