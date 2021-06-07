using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class FacturaDetalle
    {
        public int ID_FD { get; set; }
        public int ID_Producto { get; set; }
        public int ID_Factura { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
