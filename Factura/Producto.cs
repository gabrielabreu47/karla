using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string Nom_Pro { get; set; }
        public double Precio { get; set; }
        public double Precio_Venta { get; set; }
        public int Cantidad { get; set; }
        public int Cod_Cla { get; set; }
        public int Cod_Supli { get; set; }
        public int Activo { get; set; }

    }
}
