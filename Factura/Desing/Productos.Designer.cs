namespace Factura
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.ProductosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIDPRO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNOMPRO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClasificaciones = new System.Windows.Forms.Button();
            this.cbClasification = new System.Windows.Forms.ComboBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(635, 217);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 22);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "Ver deshabilitados";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(509, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 45;
            this.button5.Text = "Habilitar/Desabilitar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ProductosdataGridView1
            // 
            this.ProductosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosdataGridView1.Location = new System.Drawing.Point(19, 245);
            this.ProductosdataGridView1.Name = "ProductosdataGridView1";
            this.ProductosdataGridView1.Size = new System.Drawing.Size(726, 150);
            this.ProductosdataGridView1.TabIndex = 44;
            this.ProductosdataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductosdataGridView1_RowHeaderMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(256, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Suplidores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(246, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Clasificacion";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(428, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 39;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(751, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(751, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIDPRO
            // 
            this.txtIDPRO.Location = new System.Drawing.Point(333, 62);
            this.txtIDPRO.Name = "txtIDPRO";
            this.txtIDPRO.Size = new System.Drawing.Size(73, 20);
            this.txtIDPRO.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(280, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "ID_Pro";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(335, 194);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(77, 20);
            this.txtPrecio.TabIndex = 32;
            // 
            // txtNOMPRO
            // 
            this.txtNOMPRO.Location = new System.Drawing.Point(334, 117);
            this.txtNOMPRO.Name = "txtNOMPRO";
            this.txtNOMPRO.Size = new System.Drawing.Size(158, 20);
            this.txtNOMPRO.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(211, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Precio de Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(262, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nom_Pro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(742, 433);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 22);
            this.button6.TabIndex = 102;
            this.button6.Text = "Volver al menu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(335, 219);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(77, 20);
            this.txtPrecioVenta.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(220, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 103;
            this.label5.Text = "Precio de Venta";
            // 
            // btnClasificaciones
            // 
            this.btnClasificaciones.Location = new System.Drawing.Point(728, 62);
            this.btnClasificaciones.Name = "btnClasificaciones";
            this.btnClasificaciones.Size = new System.Drawing.Size(89, 23);
            this.btnClasificaciones.TabIndex = 105;
            this.btnClasificaciones.Text = "Clasificaciones";
            this.btnClasificaciones.UseVisualStyleBackColor = true;
            this.btnClasificaciones.Click += new System.EventHandler(this.btnClasificaciones_Click);
            // 
            // cbClasification
            // 
            this.cbClasification.FormattingEnabled = true;
            this.cbClasification.Location = new System.Drawing.Point(333, 142);
            this.cbClasification.Name = "cbClasification";
            this.cbClasification.Size = new System.Drawing.Size(159, 21);
            this.cbClasification.TabIndex = 106;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(333, 168);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(159, 21);
            this.cbSupplier.TabIndex = 107;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(844, 467);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.cbClasification);
            this.Controls.Add(this.btnClasificaciones);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ProductosdataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIDPRO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNOMPRO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView ProductosdataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIDPRO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNOMPRO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnClasificaciones;
        private System.Windows.Forms.ComboBox cbClasification;
        private System.Windows.Forms.ComboBox cbSupplier;
    }
}