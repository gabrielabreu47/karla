using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class BillServices : Database, IRepsitory<FacturaEntity>
    {
        public bool Add(FacturaEntity item)
        {
            SqlCommand command = new SqlCommand("insert into Factura (ID_Usuario, ID_Cliente, FECHA_COMPRA, ID_FP)"
                +" values(@ID_Usuario, @ID_Cliente, @Fecha_Compra, @ID_FP)");
            command.Parameters.AddWithValue("@ID_Usuario", item.ID_User);
            command.Parameters.AddWithValue("@ID_Cliente", item.Id_Customer);
            command.Parameters.AddWithValue("@Fecha_Compra", item.Date);
            command.Parameters.AddWithValue("@ID_FP", item.FP);

            return ExecuteDml(command);
        }

        public bool Desactivar(FacturaEntity item)
        {
            SqlCommand command = new SqlCommand("DELETE Factura WHERE ID_Factura = @id");
            command.Parameters.AddWithValue("@id", item.ID_Factura);

            return ExecuteDml(command);
        }

        public bool Edit(FacturaEntity item)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(int query, string value)
        {
            string cmd;
            if(query == 0)
            {
                cmd = "SELECT F.ID_Factura, U.Usuario, C.Nom_Cliente + ' ' + C.Apellido As Cliente, F.FECHA_COMPRA, F.ID_FP"
                       +" FROM FACTURA F"
                       +" INNER JOIN USUARIOS U ON F.ID_Usuario = U.ID_Usuario"
                       +" INNER JOIN Clientes C ON F.ID_Cliente = C.ID_Cliente";
            }
            else if(query == 1)
            {
                cmd = "SELECT F.ID_Factura, U.Usuario, C.Nom_Cliente + ' ' + C.Apellido As Cliente, F.FECHA_COMPRA, F.ID_FP"
                      + " FROM FACTURA F"
                      + " INNER JOIN USUARIOS U ON F.ID_Usuario = U.ID_Usuario"
                      + " INNER JOIN Clientes C ON F.ID_Cliente = F.ID_Cliente"
                      + " WHERE ID_Factura = " +  value;
            }
            else
            {
                cmd = "Select Top 1 ID_Factura AS id From FACTURA ORDER BY id DESC";
            }
            return ExecuteRead(cmd);
        }
         
        public bool addFacturaDetalle(FacturaDetalle factura)
        {
            
                SqlCommand command = new SqlCommand("insert into Detalles_Factura (ID_Pro, Cod_Fact, Cantidad) values(@ID_Pro,@Cod_Fact,@Cantidad)");
                command.Parameters.AddWithValue("@ID_Pro", factura.ID_Producto);
                command.Parameters.AddWithValue("@Cod_Fact", factura.ID_Factura);
                command.Parameters.AddWithValue("@Cantidad", factura.Cantidad);
                if (!ExecuteDml(command))
                {
                    return false;
                }
            
            return true;
        }
    }
}
