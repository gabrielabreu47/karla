using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Factura
{
    public class ProductServices : Database, IRepsitory<Producto>
    {
        public bool Add(Producto item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Productos (Nom_Pro, Precio, Precio_Venta, Cantidad, Cod_Cla, Cod_Supli, Activo) "
                                             + "VALUES(@name, @precio, @preciov, @cantidad, @codcla, @codsupli, @activo)");
            command.Parameters.AddWithValue("@name", item.Nom_Pro);
            command.Parameters.AddWithValue("@precio", item.Precio);
            command.Parameters.AddWithValue("@preciov", item.Precio_Venta);
            command.Parameters.AddWithValue("@cantidad", item.Cantidad);
            command.Parameters.AddWithValue("@codcla", item.Cod_Cla);
            command.Parameters.AddWithValue("@codsupli", item.Cod_Supli);
            command.Parameters.AddWithValue("@activo", item.Activo);

            return ExecuteDml(command);
        }

        public bool Desactivar(Producto item)
        {
            SqlCommand command = new SqlCommand("UPDATE Productos SET Activo = @activo WHERE ID_Pro = @id");
            command.Parameters.AddWithValue("@activo", item.Activo);
            command.Parameters.AddWithValue("@id", item.ID_Producto);

            return ExecuteDml(command);
        }

        public bool Edit(Producto item)
        {
            SqlCommand command = new SqlCommand("UPDATE Productos SET Nom_Pro = @name, Precio = @precio, Precio_Venta = @preciov,  Cod_Cla = @codcla, Cod_Supli = @codsupli,"
                                               + "  Activo = @activo WHERE ID_Pro = @id");
            command.Parameters.AddWithValue("@name", item.Nom_Pro);
            command.Parameters.AddWithValue("@precio", item.Precio);
            command.Parameters.AddWithValue("@preciov", item.Precio_Venta);
            command.Parameters.AddWithValue("@codcla", item.Cod_Cla);
            command.Parameters.AddWithValue("@codsupli", item.Cod_Supli);
            command.Parameters.AddWithValue("@activo", item.Activo);
            command.Parameters.AddWithValue("@id", item.ID_Producto);


            return ExecuteDml(command);
        }

        public DataTable Get(int query, string value)
        {
            string cmd = "";
            if (query == 0) //productos
            {
                cmd = "SELECT * FROM Productos";
            }
            else if(query == 5) //para compras (todos)
            {
                cmd = "SELECT P.ID_Pro, P.Nom_Pro, P.Cod_Supli, S.Compañia FROM Productos P INNER JOIN Suplidor S on P.Cod_Supli = S.Cod_Supli Where S.Activo = 1 AND P.Activo = 1";
            }
            else if (query == 4) //para factura
            {
                cmd = "SELECT * FROM Productos WHERE ID_Pro = " + value + " AND Activo = 1";
            }
            else if (query == 3) //para compras (especifico)
            {
                cmd = "SELECT P.ID_Pro, P.Nom_Pro, P.Cod_Supli FROM Productos P INNER JOIN Suplidor S on P.Cod_Supli = S.Cod_Supli WHERE S.Activo = 1 AND P.ID_Pro like '" + value + "%' OR P.Nom_Pro like '" + value + "%' OR P.Cod_Supli like '" + value +"%' and P.Activo = 1";
            }
            else if (query == 1)
            {
                cmd = "SELECT * FROM Productos WHERE ID_Pro = " + value; //productos 
            }
            else
            {
                cmd = "SELECT * FROM Productos WHERE Activo = " + value; //productos
            }
            return ExecuteRead(cmd);
        }
        public bool EditCantidad(Producto item)
        {
            SqlCommand command = new SqlCommand("UPDATE Productos SET Cantidad = @cantidad WHERE ID_Pro = @id");
            command.Parameters.AddWithValue("@cantidad", item.Cantidad);
            command.Parameters.AddWithValue("@id", item.ID_Producto);

            return ExecuteDml(command);
        }
    }
}
