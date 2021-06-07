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
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menú_Load(object sender, EventArgs e)
        {
            if(UserLogged.Instance.user.Tipo == 0)
            {
                //nada
            }
            else if (UserLogged.Instance.user.Tipo == 1)
            {
                suplidorToolStripMenuItem.Enabled = false;
                productosToolStripMenuItem.Enabled = false;
                comprasToolStripMenuItem.Enabled = false;
                reportesToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
            }
            else if (UserLogged.Instance.user.Tipo == 2)
            {
                clientesToolStripMenuItem.Enabled = false;
                facturasToolStripMenuItem.Enabled = false;
                reportesToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
            }
            else
            {
                menuStrip1.Enabled = false;
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void suplidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suplidores suplidores = new Suplidores();
            suplidores.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.Show();
            this.Hide();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDesing user = new UserDesing();
            user.Show();
            this.Hide();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desing.Reportes report = new Desing.Reportes();
            report.Show();
            this.Hide();
        }
    }
}
