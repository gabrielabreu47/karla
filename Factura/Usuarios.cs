using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class Usuarios
    {
        public int ID_User { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public int ID_Empleado { get; set; }
        public int Tipo { get; set; }
        public int Activo { get; set; }

    }
}
