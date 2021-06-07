namespace Factura
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvBuy = new System.Windows.Forms.DataGridView();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Supli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFP = new System.Windows.Forms.ComboBox();
            this.ID_FP = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(197, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 28;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(8, 94);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(475, 91);
            this.dgvProduct.TabIndex = 27;
            this.dgvProduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduct_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(262, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(332, 58);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(64, 20);
            this.txtCantidad.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(510, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(181, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvBuy
            // 
            this.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.Nom_Pro,
            this.ID_Supli,
            this.Cantidad});
            this.dgvBuy.Location = new System.Drawing.Point(8, 227);
            this.dgvBuy.Name = "dgvBuy";
            this.dgvBuy.ReadOnly = true;
            this.dgvBuy.Size = new System.Drawing.Size(475, 267);
            this.dgvBuy.TabIndex = 33;
            this.dgvBuy.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBuy_RowHeaderMouseClick);
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "Codigo de Producto";
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.ReadOnly = true;
            // 
            // Nom_Pro
            // 
            this.Nom_Pro.HeaderText = "Descripcion";
            this.Nom_Pro.Name = "Nom_Pro";
            this.Nom_Pro.ReadOnly = true;
            // 
            // ID_Supli
            // 
            this.ID_Supli.HeaderText = "Codigo de Suplidor";
            this.ID_Supli.Name = "ID_Supli";
            this.ID_Supli.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(408, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "Agregar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(15, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Resumen";
            // 
            // cbFP
            // 
            this.cbFP.FormattingEnabled = true;
            this.cbFP.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cbFP.Location = new System.Drawing.Point(8, 528);
            this.cbFP.Name = "cbFP";
            this.cbFP.Size = new System.Drawing.Size(100, 21);
            this.cbFP.TabIndex = 102;
            // 
            // ID_FP
            // 
            this.ID_FP.AutoSize = true;
            this.ID_FP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ID_FP.Location = new System.Drawing.Point(12, 508);
            this.ID_FP.Name = "ID_FP";
            this.ID_FP.Size = new System.Drawing.Size(105, 17);
            this.ID_FP.TabIndex = 101;
            this.ID_FP.Text = "Forma de Pago";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(8, 56);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(167, 20);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(525, 528);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 22);
            this.button7.TabIndex = 103;
            this.button7.Text = "Volver al menu";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(643, 559);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.cbFP);
            this.Controls.Add(this.ID_FP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dgvBuy);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvBuy;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFP;
        private System.Windows.Forms.Label ID_FP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Supli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button7;
    }
}