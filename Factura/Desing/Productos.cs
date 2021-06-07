using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factura;

namespace Factura
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        #region Instancias_Variables
        ProductServices productServices = new ProductServices();
        Producto producto = new Producto();
        private bool Editar { get; set; } = false;
        #endregion

        private void GetAll(bool activo)
        {
            if (activo)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = productServices.Get(10, "1");
                ProductosdataGridView1.DataSource = bindingSource;
                checkBox1.Checked = false;
            }
            else
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = productServices.Get(10, "0");
                ProductosdataGridView1.DataSource = bindingSource;
                checkBox1.Checked = true;
            }
        }
        private void GetSpecific(string value)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = productServices.Get(1, value);
            ProductosdataGridView1.DataSource = bindingSource;
        }
        private void Eject(bool Editar)
        {
            if (!Editar)
            {
                producto.Nom_Pro = txtNOMPRO.Text;
                producto.Cantidad =  0;
                producto.Cod_Cla = Convert.ToInt32(cbClasification.SelectedValue);
                producto.Cod_Supli = Convert.ToInt32(cbSupplier.SelectedValue);
                producto.Activo = 1;
                producto.Precio = Convert.ToDouble(txtPrecio.Text);
                producto.Precio_Venta = Convert.ToDouble(txtPrecioVenta.Text);
                if (productServices.Add(producto))
                {
                    MessageBox.Show("Producto agregado correctamente");
                    GetAll(true);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el Prodcuto");
                }
            }
            else
            {
                producto.ID_Producto = Convert.ToInt32(txtIDPRO.Text);
                producto.Nom_Pro = txtNOMPRO.Text;
                producto.Cod_Cla = Convert.ToInt32(cbClasification.SelectedValue);
                producto.Cod_Supli = Convert.ToInt32(cbSupplier.SelectedValue);
                producto.Activo = 1;
                producto.Precio = Convert.ToDouble(txtPrecio.Text);
                producto.Precio_Venta = Convert.ToDouble(txtPrecioVenta.Text);
                if (productServices.Edit(producto))
                {
                    MessageBox.Show("Producto editado correctamente");
                    if (checkBox1.Checked)
                        GetAll(false);
                    else
                        GetAll(true);
                }
                else
                {
                    MessageBox.Show("No se pudo editar el Prodcuto");
                }
                txtIDPRO.Enabled = true;
                button1.Enabled = true;
                Editar = false;
            }
            Clear();
            GetAll(true);
        }
        private void Desactivar(int id, bool activar)
        {
            if (!activar)
            {
                producto.ID_Producto = id;
                producto.Activo = 0;
                productServices.Desactivar(producto);
            }
            else
            {
                producto.ID_Producto = id;
                producto.Activo = 1;
                productServices.Desactivar(producto);
            }

        }
        private void Clear()
        {
            FillCbClasification();
            FillCbSupplier();
            txtIDPRO.Clear();
            txtNOMPRO.Clear();
            txtPrecio.Clear();
            txtPrecioVenta.Clear();
            GetAll(true);
            ProductosdataGridView1.ClearSelection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetSpecific(txtIDPRO.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
            txtIDPRO.Enabled = true;
            button1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(ProductosdataGridView1.SelectedRows.Count == 1)
            {
                if (Convert.ToInt32(ProductosdataGridView1.CurrentRow.Cells[7].Value) == 0)
                    Desactivar(Convert.ToInt32(ProductosdataGridView1.CurrentRow.Cells[0].Value), true);
                else
                    Desactivar(Convert.ToInt32(ProductosdataGridView1.CurrentRow.Cells[0].Value), false);
                GetAll(true);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtIDPRO.Text = ProductosdataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNOMPRO.Text = ProductosdataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = ProductosdataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrecioVenta.Text = ProductosdataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbClasification.SelectedValue = ProductosdataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbSupplier.SelectedValue = ProductosdataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtIDPRO.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            Editar = true;
        }

        private void ProductosdataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(Convert.ToInt32(ProductosdataGridView1.CurrentRow.Cells[7].Value) == 1)
            button3.Enabled = true;
            else
                button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eject(Editar);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                GetAll(false);
            }
            else
                GetAll(true);
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            GetAll(true);
            FillCbClasification();
            FillCbSupplier();
        }
        private void FillCbClasification()
        {
            ClasificationServices clasificationService = new ClasificationServices();
            var clasifications = clasificationService.Get(0, "");
            cbClasification.ValueMember = "Cod_Cla";
            cbClasification.DisplayMember = "Clasificacion";
            cbClasification.DataSource = clasifications;
        }
        private void FillCbSupplier()
        {
            SupplierServices supplierServices = new SupplierServices();
            var suppliers = supplierServices.Get(0, "");
            cbSupplier.ValueMember = "Cod_Supli";
            cbSupplier.DisplayMember = "Compañia";
            cbSupplier.DataSource = suppliers;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú menu = new Menú();
            menu.Show();
        }

        private void btnClasificaciones_Click(object sender, EventArgs e)
        {
            Desing.Clasificacionapartado clasificiacion = new Desing.Clasificacionapartado();
            clasificiacion.ShowDialog();
        }
    }
}
