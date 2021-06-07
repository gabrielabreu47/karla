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
    public partial class UserDesing : Form
    {
        public UserDesing()
        {
            InitializeComponent();
        }
        #region Entities_Services
        Usuarios usuarios = new Usuarios();
        UserServices Userservices = new UserServices();
        private bool Editar { get; set; } = false;
        #endregion
        private void GetAll(bool activo)
        {
            if (activo)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = Userservices.Get(1, "1"); //eso
                dataGridViewUSUARIOS.DataSource = bindingSource;
                checkBox1.Checked = false;
            }
            else
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = Userservices.Get(1, "0");
                dataGridViewUSUARIOS.DataSource = bindingSource;
                checkBox1.Checked = true;
            }
        }
        private void GetSpecific(string value)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Userservices.Get(0, value); //ya instanciaste a UserServices, no es necesario usarlo otra vez, ahora tienes que ver que es lo que te pide el metodo como parametro
            dataGridViewUSUARIOS.DataSource = bindingSource;
        }
        private void Add()
        {
            usuarios.Usuario = textusuario.Text;
            usuarios.Contraseña = textpassword.Text;
            usuarios.ID_Empleado = Convert.ToInt32(textIDempleado.Text);
            usuarios.Tipo = Convert.ToInt16(TIPO.Text);
            usuarios.Activo = 1;
            if (Userservices.Add(usuarios))
            {
                MessageBox.Show("Usuario agregado correctamente");
            }
            else
            {
                MessageBox.Show("No funciono");
            }
        }

        private void Edit()
        {
            usuarios.ID_User = Convert.ToInt32(textIDusuario.Text);
            usuarios.Usuario = textusuario.Text;
            usuarios.Contraseña = textpassword.Text;
            usuarios.ID_Empleado = Convert.ToInt16(textIDempleado.Text);
            usuarios.Tipo = Convert.ToInt16(TIPO.Text);
            usuarios.Activo = 1;
            if (Userservices.Edit(usuarios))
            {
                MessageBox.Show("Usuario agregado correctamente");
            }
            else
            {
                MessageBox.Show("No funciono");
            }
            Editar = false;
        }
        private void Deshabilitar(int id, bool activo)
        {
            if (!activo)
            {
                usuarios.ID_User = id;
                usuarios.Activo = 1;
                Userservices.Desactivar(usuarios);
            }
            else
            {
                usuarios.ID_User = id;
                usuarios.Activo = 0;
                Userservices.Desactivar(usuarios);
            }
        }
        private void Clear()
        {
            textIDusuario.Clear();
            textusuario.Clear();
            textpassword.Clear();
            textIDempleado.Clear();
            TIPO.Clear();
            checkBox1.Checked = false;
            Editar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetSpecific(textIDusuario.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button5_Click(object sender, EventArgs e)
     {
            if(Convert.ToInt32(dataGridViewUSUARIOS.CurrentRow.Cells[5].Value) == 1)
            {
                Deshabilitar(Convert.ToInt32(dataGridViewUSUARIOS.CurrentRow.Cells[0].Value),true);
            }
            else
            {
                Deshabilitar(Convert.ToInt32(dataGridViewUSUARIOS.CurrentRow.Cells[0].Value), false);
            }
            GetAll(true);
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit();
            GetAll(true);
            Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Editar)
                Add();
            else
                Edit();

            GetAll(true);
            Clear();
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

        private void UserDesing_Load(object sender, EventArgs e)
        {
            GetAll(true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menú menu = new Menú();
            menu.Show();
        }
        private void datagridviewUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) 
        {
            textIDusuario.Text = dataGridViewUSUARIOS.CurrentRow.Cells[0].Value.ToString();
            textusuario.Text = dataGridViewUSUARIOS.CurrentRow.Cells[1].Value.ToString();
            textpassword.Text = dataGridViewUSUARIOS.CurrentRow.Cells[2].Value.ToString();
            textIDempleado.Text = dataGridViewUSUARIOS.CurrentRow.Cells[3].Value.ToString();
            TIPO.Text = dataGridViewUSUARIOS.CurrentRow.Cells[4].Value.ToString();
            Editar = true;
        }
    }

}
