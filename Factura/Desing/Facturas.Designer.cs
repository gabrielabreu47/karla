namespace Factura
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.btnPrint = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.ID_FP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEditBill = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtProductCount = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClientSearch = new System.Windows.Forms.Button();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbFP = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(323, 431);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 99;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 98;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label16.Location = new System.Drawing.Point(534, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 17);
            this.label16.TabIndex = 97;
            this.label16.Text = "Fecha";
            // 
            // ID_FP
            // 
            this.ID_FP.AutoSize = true;
            this.ID_FP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ID_FP.Location = new System.Drawing.Point(544, 252);
            this.ID_FP.Name = "ID_FP";
            this.ID_FP.Size = new System.Drawing.Size(105, 17);
            this.ID_FP.TabIndex = 95;
            this.ID_FP.Text = "Forma de Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(322, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 94;
            this.label7.Text = "Descripción";
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Enabled = false;
            this.txtProductDesc.Location = new System.Drawing.Point(404, 281);
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(275, 20);
            this.txtProductDesc.TabIndex = 93;
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(290, 250);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(56, 23);
            this.btnProductSearch.TabIndex = 92;
            this.btnProductSearch.Text = "Buscar";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Location = new System.Drawing.Point(404, 431);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBill.TabIndex = 91;
            this.btnDeleteBill.Text = "Eliminar";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(347, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 85;
            this.label13.Text = "Precio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(88, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 84;
            this.label12.Text = "Total a pagar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label9.Location = new System.Drawing.Point(207, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(293, 39);
            this.label9.TabIndex = 83;
            this.label9.Text = "El control 20 y 10.";
            // 
            // btnEditBill
            // 
            this.btnEditBill.Location = new System.Drawing.Point(568, 431);
            this.btnEditBill.Name = "btnEditBill";
            this.btnEditBill.Size = new System.Drawing.Size(75, 23);
            this.btnEditBill.TabIndex = 82;
            this.btnEditBill.Text = "Editar";
            this.btnEditBill.UseVisualStyleBackColor = true;
            this.btnEditBill.Click += new System.EventHandler(this.btnEditBill_Click);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Enabled = false;
            this.txtProductPrice.Location = new System.Drawing.Point(401, 253);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(129, 20);
            this.txtProductPrice.TabIndex = 81;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(188, 432);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 80;
            // 
            // txtProductCount
            // 
            this.txtProductCount.Location = new System.Drawing.Point(197, 282);
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.Size = new System.Drawing.Size(96, 20);
            this.txtProductCount.TabIndex = 79;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(187, 250);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(95, 20);
            this.txtProductID.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(130, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 76;
            this.label10.Text = "Cantidad";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Cantidad.Location = new System.Drawing.Point(130, 253);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(51, 17);
            this.Cantidad.TabIndex = 75;
            this.Cantidad.Text = "ID_Pro";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(655, 309);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(90, 22);
            this.btnAddProduct.TabIndex = 74;
            this.btnAddProduct.Text = "Cargar a la lista";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.Location = new System.Drawing.Point(486, 431);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(75, 23);
            this.btnAddBill.TabIndex = 73;
            this.btnAddBill.Text = "Guardar";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.Cant,
            this.Precio,
            this.Descripción,
            this.Total});
            this.dgvDetail.Location = new System.Drawing.Point(101, 309);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(542, 111);
            this.dgvDetail.TabIndex = 72;
            this.dgvDetail.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDetail_RowHeaderMouseClick);
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID_Producto";
            this.ID_Producto.Name = "ID_Producto";
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cant";
            this.Cant.Name = "Cant";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 231);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(107, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 71;
            this.pictureBox3.TabStop = false;
            // 
            // btnClientSearch
            // 
            this.btnClientSearch.Location = new System.Drawing.Point(248, 118);
            this.btnClientSearch.Name = "btnClientSearch";
            this.btnClientSearch.Size = new System.Drawing.Size(75, 23);
            this.btnClientSearch.TabIndex = 70;
            this.btnClientSearch.Text = "Buscar";
            this.btnClientSearch.UseVisualStyleBackColor = true;
            this.btnClientSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Enabled = false;
            this.txtClientLastName.Location = new System.Drawing.Point(175, 178);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(214, 20);
            this.txtClientLastName.TabIndex = 69;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(175, 122);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(67, 20);
            this.txtClientID.TabIndex = 68;
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Location = new System.Drawing.Point(175, 151);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(214, 20);
            this.txtClientName.TabIndex = 67;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Enabled = false;
            this.txtEmployeeName.Location = new System.Drawing.Point(461, 149);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(229, 20);
            this.txtEmployeeName.TabIndex = 66;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Location = new System.Drawing.Point(497, 120);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(67, 20);
            this.txtEmployeeID.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(396, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(391, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "ID_Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(104, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(104, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(93, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID_Cliente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(410, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // cbFP
            // 
            this.cbFP.FormattingEnabled = true;
            this.cbFP.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cbFP.Location = new System.Drawing.Point(655, 252);
            this.cbFP.Name = "cbFP";
            this.cbFP.Size = new System.Drawing.Size(100, 21);
            this.cbFP.TabIndex = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 22);
            this.button1.TabIndex = 101;
            this.button1.Text = "Volver al menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(698, 416);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 23);
            this.btnClear.TabIndex = 102;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbFP);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ID_FP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProductDesc);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEditBill);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtProductCount);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnClientSearch);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label ID_FP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductDesc;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditBill;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtProductCount;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnClientSearch;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox cbFP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
    }
}