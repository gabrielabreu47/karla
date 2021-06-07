using Factura.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura.Desing
{
    public partial class VerReportes : Form
    {
        public VerReportes()
        {
            InitializeComponent();
        }
        public int Case { get; set; } //Tipo de reporte 0 - factura, 1 - clientes, 2 - suplidor
        public int ID { get; set; }
        public DataTable factura { get; set; } = new DataTable();
        ReportServices reportServices = new ReportServices();

        private DataTable generateReport()
        {
            DataTable result = new DataTable();
            string query;
            switch (Case)
            {
                case 0:
                    query = "EXEC BILL_DETAILS @id_bill = "+ ID;
                    result = reportServices.GetWhateverYouWant(query);
                    break;
                case 1:
                    query = "EXEC REPORT_CUSTOMER @id_customer = " + ID;
                    result = reportServices.GetWhateverYouWant(query);
                    break;
                case 2:
                    query = "EXEC REPORT_SUPPLIER @id_supplier = " + ID;
                    result = reportServices.GetWhateverYouWant(query);
                    break;
            }
            return result;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void VerReportes_Load(object sender, EventArgs e)
        {
            FillReport();
        }
        private void FillReport()
        {
            if (Case == 0)
            {
                tabControl1.SelectTab(0);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                txtClientFactura.Text = factura.Rows[0][2].ToString();
                txtUserFactura.Text = factura.Rows[0][1].ToString();
                if (Convert.ToInt32(factura.Rows[0][4].ToString()) == 0)
                {
                    txtFPFactura.Text = "Efectivo";
                }
                else
                {
                    txtFPFactura.Text = "Tarjeta de Credito";
                }
                txtFechaFactura.Text = factura.Rows[0][3].ToString();
                dgvFactura.DataSource = generateReport();
                txtTotalFactura.Text = runTotal().ToString();
            }
            else if (Case == 1)
            {
                tabControl1.SelectTab(1);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage3);
                DataTable client = new DataTable();
                client = generateReport();
                txtClient.Text = client.Rows[0][0].ToString() + " | " + client.Rows[0][1].ToString();
                txtCedulaClient.Text = client.Rows[0][2].ToString();
                txtPhoneClient.Text = client.Rows[0][3].ToString();
                txtTotalClient.Text = client.Rows[0][4].ToString();
                dgvClient.DataSource = reportServices.GetWhateverYouWant("SELECT F.ID_Factura, U.Usuario, C.Nom_Cliente + ' ' + C.Apellido As Cliente, F.FECHA_COMPRA, F.ID_FP " +
                "FROM FACTURA F " +
                "INNER JOIN USUARIOS U ON F.ID_Usuario = U.ID_Usuario " +
                "INNER JOIN Clientes C ON F.ID_Cliente = F.ID_Cliente WHERE F.ID_Cliente = " + client.Rows[0][0].ToString());
            }
            else if (Case == 2)
            {
                tabControl1.SelectTab(2);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage1);
                DataTable supplier = new DataTable();
                supplier = generateReport();
                if (supplier.Rows.Count == 0)
                {
                    MessageBox.Show("No hay suficiente informacion de este suplidor para poder realizar un reporte");
                    this.Close();
                }
                else
                {
                    txtSupplier.Text = supplier.Rows[0][0].ToString() + " | " + supplier.Rows[0][1].ToString();
                    txtRepreSupplier.Text = supplier.Rows[0][2].ToString();
                    txtPhoneSupplier.Text = supplier.Rows[0][3].ToString();
                    txtProductMostBuyedSupplier.Text = supplier.Rows[0][4].ToString();
                    dgvSupplier.DataSource = reportServices.GetWhateverYouWant("SELECT P.ID_Pro as Codigo, P.Nom_Pro as Producto, (SUM(DF.Cantidad)) AS 'Cantidad de veces vendido' FROM Productos P" +
                    " INNER JOIN Detalles_Factura DF ON P.ID_Pro = DF.ID_Pro" +
                    " WHERE P.Cod_Supli = " + supplier.Rows[0][0].ToString() +
                    " Group BY P.Nom_Pro, P.ID_Pro");
                }
            }
        }

        private double runTotal()
        {
            double total = 0;
            for(int i = 0; i < dgvFactura.Rows.Count - 1; i++)
            {
                total += Convert.ToDouble(dgvFactura.Rows[i].Cells[4].Value.ToString());
            }
            return total;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
