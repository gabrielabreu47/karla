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
    public partial class Clasificacionapartado : Form
    {
        public Clasificacionapartado()
        {
            InitializeComponent();
        }

        Clasificacion cla = new Clasificacion();
        ClasificationServices cs = new ClasificationServices();

        private void Get()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = cs.Get(0, "");
            dataGridView1.DataSource = bindingSource;
        }
        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = cs.Get(1, textBox1.Text);
            dataGridView1.DataSource = bindingSource;
        }

        private void Clasificacionapartado_Load(object sender, EventArgs e)
        {
            Get();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cla.Clasific = textBox2.Text;
            if (cs.Add(cla))
            {
                MessageBox.Show("Clasificacion agregada correctamente");
                Get();
                Clear();
            }
            else
            {
                MessageBox.Show("No funciono");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cla.ID_Clasificacion = Convert.ToInt32(textBox1.Text);
            cla.Clasific = textBox2.Text;
            if (cs.Edit(cla))
            {
                Get();
                MessageBox.Show("Clasificacion editada correctamente");
                Clear();
            }
            else
            {
                MessageBox.Show("No funciono");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
            Get();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú menu = new Menú();
            menu.Show();
        }
    }
}
