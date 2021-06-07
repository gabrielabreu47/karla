using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Factura
{
    public class UserServices : Database, IRepsitory<Usuarios>
    {
        public bool Add(Usuarios item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO USUARIOS (Usuario, Contraseña, ID_Empleado, Tipo, Activo) "
                                             + "VALUES(@user, @pass, @id_employee, @type, @activo)");
            command.Parameters.AddWithValue("@user", item.Usuario);
            command.Parameters.AddWithValue("@pass", item.Contraseña);
            command.Parameters.AddWithValue("@id_employee", item.ID_Empleado);
            command.Parameters.AddWithValue("@type", item.Tipo);
            command.Parameters.AddWithValue("@activo", item.Activo);

            return ExecuteDml(command);
        }

        public bool Desactivar(Usuarios item)
        {
            SqlCommand command = new SqlCommand("UPDATE USUARIOS SET Activo = @activo"
                                              + "  WHERE ID_Usuario = @id");
            command.Parameters.AddWithValue("@activo", item.Activo);
            command.Parameters.AddWithValue("@id", item.ID_User);

            return (ExecuteDml(command));
        }

        public bool Edit(Usuarios item)
        {
            SqlCommand command = new SqlCommand("UPDATE USUARIOS SET Usuario = @user, Contraseña = @pass, ID_Empleado = @id_employee, Tipo = @type, Activo = @activo"
                                              + "  WHERE ID_Usuario = @id");
            command.Parameters.AddWithValue("@user", item.Usuario);
            command.Parameters.AddWithValue("@pass", item.Contraseña);
            command.Parameters.AddWithValue("@id_employee", item.ID_Empleado);
            command.Parameters.AddWithValue("@id", item.ID_User);
            command.Parameters.AddWithValue("@type", item.Tipo);
            command.Parameters.AddWithValue("@activo", item.Activo);

            return ExecuteDml(command);
        }
        
        public DataTable Get(int query, string value)
        {
            string cmd = "";
            if (query == 0)
            {
                cmd = "SELECT * FROM USUARIOS";
            }
            else if(query == 73)
            {
                cmd = "SELECT * FROM USUARIOS WHERE ID = " + value;
            }
            else
            {
                cmd = "SELECT * FROM USUARIOS WHERE Activo = " + value;
            }


            return ExecuteRead(cmd);
        }
        public DataTable Login(string value, string second_value)
        {
            string cmd;
            cmd = "SELECT * FROM USUARIOS WHERE Usuario = '" + value + "' AND Contraseña = '" + second_value + "' AND Activo = 1";
            return ExecuteRead(cmd);
        }
    }

}
