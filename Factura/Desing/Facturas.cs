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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        #region Entities_Services
        FacturaEntity factura = new FacturaEntity();
        BillServices facturaServices = new BillServices();
        Cliente cliente = new Cliente();
        CustomerServices clienteServices = new CustomerServices();
        Producto producto = new Producto();
        ProductServices productServices = new ProductServices();
        FacturaDetalle Fdetalle = new FacturaDetalle();
        #endregion

        private int GetCantidad(string id)
        {
            DataTable dt = new DataTable();
            dt = productServices.Get(1, id);
            return Convert.ToInt32(dt.Rows[0][3]);
        }
        private bool Compare(int Caso)
        {
            if (Caso == 1)
            {
                if (Convert.ToInt32(txtProductCount.Text) <= GetCantidad(txtProductID.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (Caso == 2)
            {
                int newCount = Convert.ToInt32(txtProductCount.Text) + Convert.ToInt32(dgvDetail.CurrentRow.Cells[1].Value);
                if (newCount <= GetCantidad(txtProductID.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
        private void EditCantidad()
        {
            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                producto.ID_Producto = Convert.ToInt32(dgvDetail.Rows[i].Cells[0].Value);
                producto.Cantidad = GetCantidad(dgvDetail.Rows[i].Cells[0].Value.ToString()) - Convert.ToInt32(dgvDetail.Rows[i].Cells[1].Value);
                if (!productServices.EditCantidad(producto))
                {
                    MessageBox.Show("Hubo un error");
                    break;
                }
            }

        }
        private void Get(int caso)
        {
            DataTable dt = new DataTable();
            switch (caso)
            {
                case 1:
                    dt = clienteServices.Get(2, txtClientID.Text);
                    if(dt.Rows.Count == 1)
                    {
                        txtClientName.Text = dt.Rows[0][1].ToString();
                        txtClientLastName.Text = dt.Rows[0][2].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro ningun Cliente con ese codigo o el Cliente esta desactivado");
                    }
                    break;
                case 2:
                    dt = productServices.Get(4, txtProductID.Text);
                    if (dt.Rows.Count == 1)
                    {
                        txtProductDesc.Text = dt.Rows[0][1].ToString();
                        txtProductPrice.Text = dt.Rows[0][3].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro ningun Producto con ese codigo o el Producto esta desactivado");
                    }
                    break;
            }
        }
        private void GetTotal()
        {
            double total = 0;
            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvDetail.Rows[i].Cells[4].Value);
            }
            txtTotalAmount.Text = total.ToString();
        }
        private int GetFactura()
        {
            return Convert.ToInt32(facturaServices.Get(10, "").Rows[0][0]);
        }
        private void AddDetail()
        {
            bool existe = false;
            int index = 0;
            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                if (txtProductID.Text == dgvDetail.Rows[i].Cells[0].Value.ToString())
                {
                    existe = true;
                    index = i;
                }
            }
            if (!existe)
            {
                if(Compare(1))
                dgvDetail.Rows.Add(txtProductID.Text, txtProductCount.Text, txtProductPrice.Text, txtProductDesc.Text, (Convert.ToInt32(txtProductCount.Text) * Convert.ToDouble(txtProductPrice.Text)));
                else
                    MessageBox.Show("La cantidad de productos ingresada es mayor a lo dispoible en el almacen");
            }
            else
            {
                if (Compare(2))
                {
                    dgvDetail.Rows.Add(txtProductID.Text, (Convert.ToInt32(txtProductCount.Text) + Convert.ToInt32(dgvDetail.Rows[index].Cells[1].Value)),
                        txtProductPrice.Text, txtProductDesc.Text, ((Convert.ToInt32(txtProductCount.Text) + Convert.ToInt32(dgvDetail.Rows[index].Cells[1].Value)) * Convert.ToDouble(txtProductPrice.Text)));
                    dgvDetail.Rows.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("La cantidad de productos ingresada es mayor a lo dispoible en el almacen");
                }
            }
            GetTotal();

        }
        private void SelectDetail()
        {
                txtProductID.Text = dgvDetail.CurrentRow.Cells[0].Value.ToString();
                Get(2);
                txtProductCount.Text = dgvDetail.CurrentRow.Cells[1].Value.ToString();
        }
        private void EditDetail()
        {
            dgvDetail.Rows.RemoveAt(dgvDetail.CurrentRow.Index);
            AddDetail();
        }
        private void RemoveDetail()
        {
            dgvDetail.Rows.RemoveAt(dgvDetail.CurrentRow.Index);
        }
        private void SaveBill()
        {
            factura.ID_User = UserLogged.Instance.user.ID_User;
            factura.Id_Customer = Convert.ToInt32(txtClientID.Text);
            factura.Date = System.DateTime.Now.ToShortDateString();
            if (cbFP.Text == "Efectivo")
                factura.FP = 1;
            else
                factura.FP = 2;
            if (facturaServices.Add(factura))
            {
                bool ok = true;
                FacturaDetalle detalle = new FacturaDetalle();
                for (int i = 0; i < dgvDetail.Rows.Count; i++)
                {
                    Fdetalle.ID_Producto = Convert.ToInt32(dgvDetail.Rows[i].Cells[0].Value);
                    Fdetalle.Cantidad = Convert.ToInt32(dgvDetail.Rows[i].Cells[1].Value);
                    Fdetalle.ID_Factura = GetFactura();
                    detalle = Fdetalle;

                    if (facturaServices.addFacturaDetalle(detalle))
                    {
                        ok = true;
                        EditCantidad();
                    }
                    else
                    {
                        MessageBox.Show("No funciono");
                        DeleteAll(GetFactura());
                        break;
                    }
                }
                if (ok)
                {
                    MessageBox.Show("Factura agregada correctamente");
                }
            }
            else
            {
                MessageBox.Show("No funciono");
            }
        }
        private void DeleteAll(int id)
        {
            factura.ID_Factura = id;
            if (!facturaServices.Edit(factura))
            {
                MessageBox.Show("Hay datos corruptos en la base de datos");
            }
        }
        private void Clear()
        {
            txtClientID.Clear();
            txtClientLastName.Clear();
            txtClientName.Clear();
            txtEmployeeID.Clear();
            txtEmployeeName.Clear();
            txtProductCount.Clear();
            txtProductDesc.Clear();
            txtProductID.Clear();
            txtProductPrice.Clear();
            txtTotalAmount.Clear();
            cbFP.Text = "";
        }
        private void ClearProduct()
        {
            txtProductPrice.Clear();
            txtProductID.Clear();
            txtProductDesc.Clear();
            txtProductCount.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Get(1);
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Text = UserLogged.Instance.user.ID_User.ToString();
            txtEmployeeName.Text = UserLogged.Instance.user.Usuario;

        }
            
        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            Get(2);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddDetail();
            ClearProduct();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            SaveBill();
            Clear();
            this.Hide();
            Menú menu = new Menú();
            menu.Show();
        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            EditDetail();
            ClearProduct();
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            RemoveDetail();
        }

        private void dgvDetail_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectDetail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú menu = new Menú();
            menu.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClientID.Clear();
            txtClientLastName.Clear();
            txtClientName.Clear();
            txtProductCount.Clear();
            txtProductDesc.Clear();
            txtProductDesc.Clear();
            txtProductID.Clear();
            txtProductPrice.Clear();
            txtTotalAmount.Clear();
            dateTimePicker1.Value = DateTime.Now;
            while(dgvDetail.Rows.Count > 0) dgvDetail.Rows.RemoveAt(0);
        }
    }
}
