using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Factura
{
    public class BuyServices : Database, IRepsitory<Compra>
    {
        public bool Add(Compra item)
        {   
            SqlCommand command = new SqlCommand("insert into Compras (Cod_Supli, ID_FP, Fecha_Compra) values(@Cod_Supli, @ID_FP, @Fecha_Compra)");
            command.Parameters.AddWithValue("@Cod_Supli", item.Cod_Supli);
            command.Parameters.AddWithValue("@ID_FP", item.ID_FP);
            command.Parameters.AddWithValue("@Fecha_Compra", item.Fecha_Compra);

            return ExecuteDml(command);
        }

        public bool Desactivar(Compra item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Compra item)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(int query, string value)
        {
            string cmd = "";
            if(query == 0)
            {
                cmd = "SELECT C.Cod_Comp, S.Cod_Supli, S.Compañia, S.Representante, C.Fecha_Compra, C.ID_FP" 
                       +" FROM Compras C"
                       +" INNER JOIN Suplidor S ON C.Cod_Supli = S.Cod_Supli";
            }
            else if(query == 1)
            {
                cmd = "SELECT C.Cod_Comp, S.Cod_Supli, S.Compañia, S.Representante, C.Fecha_Compra, C.ID_FP"
                       + " FROM Compras C"
                       + " INNER JOIN Suplidor S ON C.Cod_Supli = S.Cod_Supli"
                       + " WHERE C.Cod_Comp = " + value;
            }
            else
            {
                cmd = "Select Top 1 Cod_Comp AS id From Compras ORDER BY id DESC";
            }
            return ExecuteRead(cmd);
        }
    }
}
