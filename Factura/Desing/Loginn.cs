using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (login())
            { //nunca uses acento Karla
                Menú menú = new Menú();
                menú.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos o cuenta desactivada");
                TxtPass.Clear();
            }
        }
        private bool login()
        {
            UserServices userServices = new UserServices();
            DataTable dt = new DataTable();
            dt = userServices.Login(TxtUser.Text, TxtPass.Text);
            if(dt.Rows.Count == 1)
            {
                UserLogged.Instance.logIn(dt);
                return true;
            }
            else
            {
                return false;
            }
            //yo hice eso? al parecer si
        }
    }
}
