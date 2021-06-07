using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public interface IRepsitory<T>
    {
        bool Add(T item);
        bool Edit(T item);
        bool Desactivar(T item);
        DataTable Get(int query, string value);
    }
}
