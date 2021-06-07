using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public sealed class UserLogged //CLASE PARA TENER SOLO UN USUARIO LOGEADO POR COMPUTADORA
    {
        public Usuarios user { get; set; } = null;

        public static UserLogged Instance { get; } = new UserLogged();

        public void logIn(DataTable dt)
        {
            Usuarios user = new Usuarios();
            user.ID_User = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
            user.Usuario = dt.Rows[0].ItemArray[1].ToString();
            user.Contraseña = dt.Rows[0].ItemArray[2].ToString();
            user.ID_Empleado = Convert.ToInt32(dt.Rows[0].ItemArray[3]);
            user.Tipo = Convert.ToInt32(dt.Rows[0].ItemArray[4]);
            user.Activo = Convert.ToInt32(dt.Rows[0].ItemArray[5]);
            this.user = user;
        }
        public void logOut()
        {
            Usuarios user = new Usuarios();
            this.user = user;
        }
    }
}
