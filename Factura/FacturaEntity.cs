using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class FacturaEntity
    {
        public int ID_Factura { get; set; }
        public int ID_User { get; set; }
        public int Id_Customer { get; set; }
        public string Date { get; set; }
        public int FP { get; set; }
    }
}
