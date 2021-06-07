using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class Empleado
    {
        public int Id_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public int Cod_Dept { get; set; }
        public double Salario { get; set; }
        public int Activo { get; set; }
    }
}
