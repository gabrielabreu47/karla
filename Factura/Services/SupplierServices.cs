using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Factura
{
    public class SupplierServices : Database, IRepsitory<Suplidor>
    {
        public bool Add(Suplidor item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Suplidor (Compañia, Representante, Telefono, Activo) "
                                              + "VALUES(@compa, @repre, @tel, @activo)");
            command.Parameters.AddWithValue("@compa", item.Compañia);
            command.Parameters.AddWithValue("@repre", item.Representante);
            command.Parameters.AddWithValue("@tel", item.Telefono);
            command.Parameters.AddWithValue("@activo", item.Activo);

            return ExecuteDml(command);
        }

        public bool Desactivar(Suplidor item)
        {
            SqlCommand command = new SqlCommand("UPDATE Suplidor SET Activo = @activo WHERE Cod_Supli = @id");
            command.Parameters.AddWithValue("@activo", item.Activo);
            command.Parameters.AddWithValue("@id", item.ID_Suplidor);

            return ExecuteDml(command);
        }

        public bool Edit(Suplidor item)
        {
            SqlCommand command = new SqlCommand("UPDATE Suplidor SET Compañia = @compa, Representante = @repre, Telefono = @tel, Activo = @activo"
                                              + "  WHERE Cod_Supli = @id");
            command.Parameters.AddWithValue("@compa", item.Compañia);
            command.Parameters.AddWithValue("@repre", item.Representante);
            command.Parameters.AddWithValue("@tel", item.Telefono);
            command.Parameters.AddWithValue("@activo", item.Activo);
            command.Parameters.AddWithValue("@id", item.ID_Suplidor);

            return ExecuteDml(command);
        }

        public DataTable Get(int query, string value)
        {
            string cmd = "";
            if (query == 0)
            {
                cmd = "SELECT * FROM Suplidor";
            }
            else if(query == 1)
            {
                cmd = "SELECT * FROM Suplidor WHERE Cod_Supli = " + value;
            }
            else
            {
                cmd = "SELECT * FROM Suplidor WHERE Activo = " + value;
            }
            return ExecuteRead(cmd);
        }
    }
}
