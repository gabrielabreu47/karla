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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        #region Entities_Services
        Cliente cliente = new Cliente();
        CustomerServices customerServices = new CustomerServices();
        private bool Editar { get; set; } = false;
        #endregion

        // LOGICA DE FUNCIONALIDAD
        private void GetAll(bool activo)
        {
            if (activo)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = customerServices.Get(4, "1");
                dgvClientes.DataSource = bindingSource;
                checkBox1.Checked = false;
            }
            else
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = customerServices.Get(4, "0");
                dgvClientes.DataSource = bindingSource;
                checkBox1.Checked = true;
            }
        }
        private void GetSpecific(string value)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = customerServices.Get(1, value);
            dgvClientes.DataSource = bindingSource;
        }
        private void AddCustomer()
        {
            cliente.Nombre = txtnombre.Text;
            cliente.Apellido = txtapellido.Text;
            cliente.Telefono = txttelefono.Text;
            cliente.Cedula = txtcedula.Text;
            cliente.Activo = 1;
            if(customerServices.Add(cliente))
            {
                MessageBox.Show("Cliente agregado correctamente");
            }
            else
            {
                MessageBox.Show("No funciono");
            }
        }
        private void EditCustomer()
        {
            cliente.ID_Cliente = Convert.ToInt32(TxtID.Text);
            cliente.Nombre = txtnombre.Text;
            cliente.Apellido = txtapellido.Text;
            cliente.Telefono = txttelefono.Text;
            cliente.Cedula = txtcedula.Text;
            cliente.Activo = 1;
            if (customerServices.Edit(cliente))
            {
                MessageBox.Show("Cliente editado correctamente");
            }
            else
            {
                MessageBox.Show("No funciono");
            }
            Editar = false;
        }
        private void Deshabilitar(int id, bool activar)
        {
            if (!activar)
            {
                cliente.ID_Cliente = id;
                cliente.Activo = 0;
                customerServices.Desactivar(cliente);
            }
            else
            {
                cliente.ID_Cliente = id;
                cliente.Activo = 1;
                customerServices.Desactivar(cliente);
            }
        }

        //EN LOS BOTONES SOLO LLAMO A ESTOS METODOS, LA LOGICA ESTA PLASMADA AQUI ARRIBA, ABAJO ES SOLO PONERLA A FUNCIONAR
        //AHORA SI, DALE


        private void Clear()
        {
            txtapellido.Clear();
            txtcedula.Clear();
            TxtID.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            checkBox1.Checked = false;
            Editar = false;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            GetAll(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetSpecific(TxtID.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                GetAll(false);
            }
            else
            {
                GetAll(true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(dgvClientes.CurrentRow.Cells[5].Value) == 1)
            {
                Deshabilitar(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value),false);
            }
            else
            {
                Deshabilitar(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value), true);
            }
            GetAll(true);
            Clear();
        }

        private void txtlimpiarcliente_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCustomer();
            GetAll(true);
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Editar)
                AddCustomer();
            else
                EditCustomer();

            GetAll(true);
            Clear();
        }

        private void dgvClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtID.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txttelefono.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtcedula.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            Editar = true;
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú menu = new Menú();
            menu.Show();
        }
    }
}
