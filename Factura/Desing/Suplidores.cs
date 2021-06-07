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
    public partial class Suplidores : Form
    {
        public Suplidores()
        {
            InitializeComponent();
        }


        public bool Editar { get; set; }
        Suplidor suplidor = new Suplidor();
        SupplierServices ss = new SupplierServices();

        private void get(string status)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ss.Get(4, status);
            dataGridViewSUPLIDOR.DataSource = bindingSource;
        }

        private void clear()
        {
            txtCODSUPLI.Clear();
            COMPAÑIA.Clear();
            TELEFONO.Clear();
            REPRESENTANTE.Clear();
            txtCODSUPLI.Enabled = true;
            button4.Enabled = true;
            Editar = false;
            checkBox1.Checked = false;
        }

        private void Suplidor_Load(object sender, EventArgs e)
        {
            get("1");
            Editar = false;
        }

        private void add()
        {
            suplidor.Compañia = COMPAÑIA.Text;
            suplidor.Representante = REPRESENTANTE.Text;
            suplidor.Telefono = TELEFONO.Text;
            suplidor.Activo = 1;
            if (ss.Add(suplidor))
            {
                MessageBox.Show("El suplidor fue agregado correctamente");
            }
            else
            {
                MessageBox.Show("NO funciono xd");
            }
        }
        private void edit()
        {
            suplidor.ID_Suplidor = Convert.ToInt32(txtCODSUPLI.Text);
            suplidor.Compañia = COMPAÑIA.Text;
            suplidor.Representante = REPRESENTANTE.Text;
            suplidor.Telefono = TELEFONO.Text;
            suplidor.Activo = 1;
            if (ss.Edit(suplidor))
            {
                MessageBox.Show("El suplidor fue editado correctamente");
            }
            else
            {
                MessageBox.Show("NO funciono xd");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Editar)
            {
                add();
                get("1");
            }
            else
            {
                edit();
                get("1");
                txtCODSUPLI.Enabled = true;
                Editar = false;
            }
            button4.Visible = true;
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCODSUPLI.Enabled = false;
            button4.Visible = false;
            Editar = true;
            txtCODSUPLI.Text = dataGridViewSUPLIDOR.CurrentRow.Cells[0].Value.ToString();
            COMPAÑIA.Text = dataGridViewSUPLIDOR.CurrentRow.Cells[1].Value.ToString();
            REPRESENTANTE.Text = dataGridViewSUPLIDOR.CurrentRow.Cells[2].Value.ToString();
            TELEFONO.Text = dataGridViewSUPLIDOR.CurrentRow.Cells[3].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            get("1");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                get("0");
            }
            else
            {
                get("1");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(dataGridViewSUPLIDOR.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione el registro que desea activar/desactivar");
            }
            else
            {
                deshabilitar(Convert.ToInt32(dataGridViewSUPLIDOR.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridViewSUPLIDOR.CurrentRow.Cells[4].Value));
            }
        }
        private void deshabilitar(int id, int activo)
        {
            if (activo == 0)
            {
                suplidor.ID_Suplidor = id;
                suplidor.Activo = 1;
                if (ss.Desactivar(suplidor))
                {
                    MessageBox.Show("Suplidor habilitado satisfactoriamente");
                    get("0");
                }
            }
            else
            {
                suplidor.ID_Suplidor = id;
                suplidor.Activo = 0;
                if (ss.Desactivar(suplidor))
                {
                    MessageBox.Show("Suplidor deshabilitado satisfactoriamente");
                    get("1");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCODSUPLI.Text == "")
            {
                MessageBox.Show("RPTM Ponga el codigo");
            }
            else
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ss.Get(1, txtCODSUPLI.Text);
                dataGridViewSUPLIDOR.DataSource = bindingSource;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú menu = new Menú();
            menu.Show();
        }
    }
}
