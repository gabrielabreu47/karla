using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Factura
{
    public class ClasificationServices : Database, IRepsitory<Clasificacion>
    {
        public bool Add(Clasificacion item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Clasificacion (Clasificacion) "
                                              + "VALUES(@nombre)");
            command.Parameters.AddWithValue("@nombre", item.Clasific);
            return (ExecuteDml(command));
        }

        public bool Desactivar(Clasificacion item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Clasificacion item)
        {
            SqlCommand command = new SqlCommand("UPDATE Clasificacion SET Clasificacion = @nombre"
                                             + "  WHERE Cod_Cla = @id");
            command.Parameters.AddWithValue("@nombre", item.Clasific);
            command.Parameters.AddWithValue("@id", item.ID_Clasificacion);
            return (ExecuteDml(command));
        }

        public DataTable Get(int query, string value)
        {
            string cmd = "";
            if (query == 0)
            {
                cmd = "SELECT * FROM Clasificacion";
            }
            else
            {
                cmd = "SELECT * FROM Clasificacion WHERE Cod_Cla = " + value;
            }
            return ExecuteRead(cmd);
        }
    }
}
