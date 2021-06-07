using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Factura
{
    public class EmployeeServices : Database, IRepsitory<Empleado>
    {
        public bool Add(Empleado item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Empleado (Nombre, Apellido, Edad, Telefono, Cedula, Cod_Dept, Salario, Activo) "
                                               + "VALUES(@name, @lastname, @age, @phone, @cedula, @department, @salary, @activo)");
            command.Parameters.AddWithValue("@name", item.Nombre);
            command.Parameters.AddWithValue("@lastname", item.Apellido);
            command.Parameters.AddWithValue("@age", item.Edad);
            command.Parameters.AddWithValue("@phone", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@department", item.Cod_Dept);
            command.Parameters.AddWithValue("@salary", item.Salario);
            command.Parameters.AddWithValue("@activo", item.Activo);

            return ExecuteDml(command);
        }

        public bool Desactivar(Empleado item)
        {
            SqlCommand command = new SqlCommand("UPDATE Empleado SET Activo = @activo WHERE Id_Empleado = @id)");
            command.Parameters.AddWithValue("@activo", item.Activo);
            command.Parameters.AddWithValue("@id", item.Id_Empleado);

            return ExecuteDml(command);
        }

        public bool Edit(Empleado item)
        {
            SqlCommand command = new SqlCommand("UPDATE Empleado SET Nombre = @name, Apellido = @lastname, Edad = @age, Telefono = @phone, Cedula = @cedula,"
                                               + " Cod_Dept = @department, Salario = @salary, Activo = @activo WHERE Id_Empleado = @id)");
            command.Parameters.AddWithValue("@name", item.Nombre);
            command.Parameters.AddWithValue("@lastname", item.Apellido);
            command.Parameters.AddWithValue("@age", item.Edad);
            command.Parameters.AddWithValue("@phone", item.Telefono);
            command.Parameters.AddWithValue("@cedula", item.Cedula);
            command.Parameters.AddWithValue("@department", item.Cod_Dept);
            command.Parameters.AddWithValue("@salary", item.Salario);
            command.Parameters.AddWithValue("@activo", item.Activo);
            command.Parameters.AddWithValue("@id", item.Id_Empleado);


            return ExecuteDml(command);
        }

        public DataTable Get(int query, string value)
        {
            string cmd = "";
            if (query == 0)
            {
                cmd = "SELECT * FROM Empleado";
            }
            else
            {
                cmd = "SELECT * FROM Empleado WHERE Id_Empleado = " + value;
            }
            return ExecuteRead(cmd);
        }
    }
}
