using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class Cliente
    {
        public int ID_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public int Activo { get; set; }
    }
}
