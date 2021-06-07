using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Factura
{
    public class DepartmentServices : Database, IRepsitory<Departamento>
    {
        public bool Add(Departamento item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Departamentos (Departamento) "
                                              + "VALUES(@nombre)");
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            return (ExecuteDml(command));
        }

        public bool Desactivar(Departamento item)
        {
            throw new NotImplementedException(); //no tiene ese campo la base de datos
        }

        public bool Edit(Departamento item)
        {
            SqlCommand command = new SqlCommand("UPDATE Departamentps SET Departamento = @nombre"
                                             + "  WHERE Cod_Dept = @id)");
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@id", item.ID_Departamento);
            return (ExecuteDml(command));
        }

        public DataTable Get(int query, string value)
        {
            string cmd = "";
            if (query == 0)
            {
                cmd = "SELECT * FROM Departamentos";
            }
            else
            {
                cmd = "SELECT * FROM Departamentos WHERE Cod_Dept = " + value;
            }
            return ExecuteRead(cmd);
        }
    }
}
