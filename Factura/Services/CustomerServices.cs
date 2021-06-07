using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Factura 
{
    public class CustomerServices : Database, IRepsitory<Cliente>
    {
        public bool Add(Cliente item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Clientes (Nom_Cliente, Apellido, Telefono, Cedula, Activo) "
                                               + "VALUES(@name, @lastname, @phone, @cedula, @activo)");
            command.Parameters.AddWithValue("@name", item.Nombre);
            command.Parameters.AddWithValue("@lastname", item.Apellido);
            command.Parameters.AddWithValue("@phone", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@activo", item.Activo);

            return ExecuteDml(command);
        }

        public bool Desactivar(Cliente item)
        {
            SqlCommand command = new SqlCommand("UPDATE Clientes SET Activo = @activo WHERE ID_Cliente = @id");
            command.Parameters.AddWithValue("@id", item.ID_Cliente);
            command.Parameters.AddWithValue("@activo", item.Activo);

            return ExecuteDml(command);
        }

        public bool Edit(Cliente item)
        {
            SqlCommand command = new SqlCommand("UPDATE Clientes SET Nom_Cliente = @name, Apellido = @lastname, Telefono = @phone, Cedula = @cedula, Activo = @activo"
                + " WHERE ID_Cliente = @id");
            command.Parameters.AddWithValue("@name", item.Nombre);
            command.Parameters.AddWithValue("@lastname", item.Apellido);
            command.Parameters.AddWithValue("@phone", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@activo", item.Activo);
            command.Parameters.AddWithValue("@id", item.ID_Cliente);

            return ExecuteDml(command);
        }

        public DataTable Get(int query, string value)
        {
            string cmd = "";
            if(query == 0)
            {
                cmd = "SELECT * FROM Clientes";
            }
            else if (query == 1)
            {
                cmd = "SELECT * FROM Clientes WHERE ID_Cliente = " + value;
            }
            else if(query == 2)
            {
                cmd = "SELECT * FROM Clientes WHERE ID_Cliente = " + value + " AND Activo = 1";
            }
            else
            {
                cmd = "SELECT * FROM Clientes WHERE Activo = " + value;
            }
            return ExecuteRead(cmd);
        }
    }
}
