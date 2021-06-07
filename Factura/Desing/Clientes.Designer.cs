namespace Factura
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtlimpiarcliente = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(580, 170);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 22);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Ver desabilitados";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(580, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Habilitar/Desabilitar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(48, 266);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(635, 172);
            this.dgvClientes.TabIndex = 34;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientes_RowHeaderMouseClick);
            // 
            // txtlimpiarcliente
            // 
            this.txtlimpiarcliente.Location = new System.Drawing.Point(580, 227);
            this.txtlimpiarcliente.Name = "txtlimpiarcliente";
            this.txtlimpiarcliente.Size = new System.Drawing.Size(118, 23);
            this.txtlimpiarcliente.TabIndex = 33;
            this.txtlimpiarcliente.Text = "Limpiar";
            this.txtlimpiarcliente.UseVisualStyleBackColor = true;
            this.txtlimpiarcliente.Click += new System.EventHandler(this.txtlimpiarcliente_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(446, 65);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(40, 20);
            this.TxtID.TabIndex = 32;
            this.TxtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.25F);
            this.label6.Location = new System.Drawing.Point(379, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID_Cliente";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(381, 189);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(172, 20);
            this.txttelefono.TabIndex = 26;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(381, 227);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(172, 20);
            this.txtcedula.TabIndex = 25;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(382, 148);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(171, 20);
            this.txtapellido.TabIndex = 24;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(382, 107);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(171, 20);
            this.txtnombre.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(380, 169);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(382, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(378, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(378, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(694, 466);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 22);
            this.button5.TabIndex = 102;
            this.button5.Text = "Volver al menu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(796, 500);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtlimpiarcliente);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button txtlimpiarcliente;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}