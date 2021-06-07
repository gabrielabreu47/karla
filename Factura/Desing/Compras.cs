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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        #region Entities_Services
        Compra compra = new Compra();
        BuyServices buyServices = new BuyServices();
        Producto producto = new Producto();
        ProductServices productServices = new ProductServices();
        Detallescompra detallesCompra = new Detallescompra();
        Detailbuyservices detailServices = new Detailbuyservices();
        private bool Editar { get; set; } = false;
        private int ID_Suplidor { get; set; } = 0;
        #endregion

        private int GetIDCompra()
        {
            DataTable dt = new DataTable();
            dt = buyServices.Get(10, "");
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        private void GetProducts()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = productServices.Get(5, "");
            dgvProduct.DataSource = bindingSource;
        }
        private void GetProductSpecific()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = productServices.Get(3, txtBuscar.Text);
            dgvProduct.DataSource = bindingSource;
        }
        private void AddItem()
        {
            if(ID_Suplidor == 0)
            {
                dgvBuy.Rows.Add(dgvProduct.CurrentRow.Cells[0].Value, dgvProduct.CurrentRow.Cells[1].Value, dgvProduct.CurrentRow.Cells[2].Value, txtCantidad.Text);
                ID_Suplidor = Convert.ToInt32(dgvProduct.CurrentRow.Cells[2].Value);
            }
            else
            {
                if (Convert.ToInt32(dgvProduct.CurrentRow.Cells[2].Value) == ID_Suplidor)
                {
                    bool existe = false;
                    int index = 0;
                    for (int i = 0; i < dgvBuy.Rows.Count; i++)
                    {
                        if(dgvBuy.Rows[i].Cells[0].Value == null)
                        {
                            existe = false;
                        }
                        else if (dgvProduct.CurrentRow.Cells[0].Value.ToString() == dgvBuy.Rows[i].Cells[0].Value.ToString())
                        {
                            existe = true;
                            index = i;
                            break;
                        }
                        else
                        {
                            existe = false;
                        }
                    }
                    if(!existe)
                    dgvBuy.Rows.Add(dgvProduct.CurrentRow.Cells[0].Value, dgvProduct.CurrentRow.Cells[1].Value, dgvProduct.CurrentRow.Cells[2].Value, txtCantidad.Text);
                    else
                    {
                        dgvBuy.Rows.Add(dgvBuy.Rows[index].Cells[0].Value, dgvBuy.Rows[index].Cells[1].Value, dgvBuy.Rows[index].Cells[2].Value, (Convert.ToInt32(txtCantidad.Text) + Convert.ToInt32(dgvBuy.Rows[index].Cells[3].Value)));
                        dgvBuy.Rows.RemoveAt(Convert.ToInt32(dgvBuy.CurrentRow.Index));
                    }
                }
                else
                {
                    MessageBox.Show("Solo puede agregar productos provenientes del mismo suplidor");
                }
            }
        }
        private void EditItem()
        {
            dgvBuy.Rows.Add(dgvBuy.CurrentRow.Cells[0].Value, dgvBuy.CurrentRow.Cells[1].Value, dgvBuy.CurrentRow.Cells[2].Value, txtCantidad.Text);
            dgvBuy.Rows.RemoveAt(Convert.ToInt32(dgvBuy.CurrentRow.Index));
        }
        private void RemoveItem()
        {
            if(dgvBuy.Rows.Count == 2)
            {
                ID_Suplidor = 0;
            }
            dgvBuy.Rows.RemoveAt(dgvBuy.CurrentRow.Index);
        }
        private void SaveBuy()
        {
            compra.Cod_Supli = ID_Suplidor;
            compra.Fecha_Compra = System.DateTime.Now.ToShortDateString();
            if (cbFP.Text == "Efectivo")
                compra.ID_FP = 1;
            else
                compra.ID_FP = 2;
            if (buyServices.Add(compra))
            {
                for (int i = 0; i < dgvBuy.Rows.Count - 1; i++)
                {
                    detallesCompra.Cod_Comp = GetIDCompra();
                    detallesCompra.ID_Pro = Convert.ToInt32(dgvBuy.Rows[i].Cells[0].Value);
                    detallesCompra.Cantidad = Convert.ToInt32(dgvBuy.Rows[i].Cells[3].Value);
                    if (detailServices.Add(detallesCompra))
                    {
                        producto.ID_Producto = Convert.ToInt32(dgvBuy.Rows[i].Cells[0].Value);
                        producto.Cantidad = Convert.ToInt32(dgvBuy.Rows[i].Cells[3].Value);
                        if (!productServices.EditCantidad(producto))
                        {
                            MessageBox.Show("No funciono");
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No funciono");
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("No funciono");
            }
        }
        private void Clear()
        {
            txtBuscar.Clear();
            txtCantidad.Clear();
            cbFP.Text = "";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetProductSpecific();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            GetProducts();
            Editar = false;
            dgvProduct.ClearSelection();
            dgvBuy.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditItem();
            GetProducts();
            Editar = false;
            dgvProduct.ClearSelection();
            dgvBuy.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveItem();
            Editar = false;
            dgvProduct.ClearSelection();
            dgvBuy.ClearSelection();
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveBuy();
            ID_Suplidor = 0;
            dgvBuy.Rows.RemoveAt(0);
            Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
                AddItem();
                GetProducts();
            Clear();
            dgvProduct.ClearSelection();
            dgvBuy.ClearSelection();
        }

        private void dgvBuy_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBuscar.Text = dgvBuy.CurrentRow.Cells[0].Value.ToString();
            txtCantidad.Text = dgvBuy.CurrentRow.Cells[3].Value.ToString();
            Editar = true;
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void dgvProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBuscar.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú menu = new Menú();
            menu.Show();
        }
    }
}
