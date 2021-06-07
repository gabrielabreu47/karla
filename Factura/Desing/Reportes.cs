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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        Services.ReportServices reportServices = new Services.ReportServices();
        private void search()
        {
            switch (cbTables.Text)
            {
                case "Facturas":
                    dgv.DataSource = reportServices.Get(1);
                    break;
                case "Clientes":
                    dgv.DataSource = reportServices.Get(2);
                    break;
                case "Suplidores":
                    dgv.DataSource = reportServices.Get(3);
                    break;
                case "Compras":
                    dgv.DataSource = reportServices.Get(4);
                    break;
                case "Usuarios":
                    dgv.DataSource = reportServices.Get(5);
                    break;
            }
        }
        private void searchSpecific()
        {
            switch (cbTables.Text)
            {
                case "Facturas":
                    dgv.DataSource = reportServices.GetSpecific(1,txtSearch.Text);
                    break;
                case "Clientes":
                    dgv.DataSource = reportServices.GetSpecific(2, txtSearch.Text);
                    break;
                case "Suplidores":
                    dgv.DataSource = reportServices.GetSpecific(3, txtSearch.Text);
                    break;
                case "Compras":
                    dgv.DataSource = reportServices.GetSpecific(4, txtSearch.Text);
                    break;
                case "Usuarios":
                    dgv.DataSource = reportServices.GetSpecific(5, txtSearch.Text);
                    break;
            }
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
            if(cbTables.Text == "Compras" | cbTables.Text == "Usuarios")
            {
                btnReport.Visible = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                searchSpecific();
            }
            else
            {
                search();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú menu = new Menú();
            menu.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            VerReportes report = new VerReportes();
            if (cbTables.Text == "Facturas")
            {
                report.ID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                report.factura.Columns.Add("ID");
                report.factura.Columns.Add("User");
                report.factura.Columns.Add("Client");
                report.factura.Columns.Add("Date");
                report.factura.Columns.Add("FP");
                DataRow fila = report.factura.NewRow();
                fila[0] = dgv.CurrentRow.Cells[0].Value;
                fila[1] = dgv.CurrentRow.Cells[1].Value;
                fila[2] = dgv.CurrentRow.Cells[2].Value;
                fila[3] = dgv.CurrentRow.Cells[3].Value;
                fila[4] = dgv.CurrentRow.Cells[4].Value;
                report.factura.Rows.Add(fila);
                report.Case = 0;
                report.ShowDialog();
            }
            else if(cbTables.Text == "Clientes")
            {
                report.ID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                report.Case = 1;
                report.ShowDialog();
            }
            else if(cbTables.Text == "Suplidores")
            {
                report.ID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                report.Case = 2;
                report.ShowDialog();
            }
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            cbTables.Text = "Facturas";
            search();
        }
    }
}
